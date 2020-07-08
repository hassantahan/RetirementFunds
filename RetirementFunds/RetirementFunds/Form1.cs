using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace RetirementFunds
{
    public partial class Form1 : Form
    {               
        public Form1()
        {
            InitializeComponent();
            GenerateChart(int.Parse(txtPeriods.Text));
            lblTotal.Text = CalculatePrincipal(int.Parse(txtPeriods.Text)).ToString("C2");
        }

        // Method that makes sure a textbox only accepts numbers (with one decimal allowed)
        private void GarbageNonText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // If the textboxes that are required to operate the calculation are empty, the Go! button is disabled.
        private void CheckIfTextBoxEmpty()
        {
            if (txtPrincipal.TextLength > 0 && txtPeriods.TextLength > 0 && txtGain.TextLength > 0 && txtCompoundingFrequency.TextLength > 0)
            {
                if (txtAnnuityPayment.Enabled == false)
                {
                    btnCalculate.Enabled = true;
                }
                else if (txtAnnuityPayment.TextLength > 0 && txtPaymentFrequency.TextLength > 0 && txtPaymentGrowth.TextLength > 0)
                {
                    btnCalculate.Enabled = true;
                }
                else
                {
                    btnCalculate.Enabled = false;
                }
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void chkAnnuity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnnuity.Checked)
            {
                txtAnnuityPayment.Enabled = true;
                txtPaymentFrequency.Enabled = true;
                txtPaymentGrowth.Enabled = true;
                chkPaymentAt.Enabled = true;
            }
            else
            {
                txtAnnuityPayment.Enabled = false;
                txtPaymentFrequency.Enabled = false;
                txtPaymentGrowth.Enabled = false;
                chkPaymentAt.Enabled = false;
            }

            CheckIfTextBoxEmpty();
        }

        private void txtPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            GarbageNonText(sender, e);
        }

        private void txtPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            CheckIfTextBoxEmpty();          
        }

        private void txtPrincipal_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Tag.Equals("dollar"))
            {
                if (txtPrincipal.TextLength > 0)
                {
                    decimal temp = decimal.Parse(txt.Text, NumberStyles.Currency);
                    txt.Text = temp.ToString("C2");
                }
                else
                {
                    txt.Text = "$0.00";
                }
            }
            else if (txt.Tag.Equals("rate"))
            {
                if (txt.TextLength > 0)
                {
                    float temp = float.Parse(txt.Text);
                    txt.Text = temp.ToString("0.00");
                }
                else
                {
                    txt.Text = "0.00";
                }
            }
            else if (txt.Tag.Equals("period"))
            {
                if (txt.TextLength > 0)
                {
                    double temp = double.Parse(txt.Text);
                    temp = Math.Round(temp);
                    txt.Text = temp.ToString();
                }
                else
                {
                    txt.Text = "1";
                }
            }

            CheckIfTextBoxEmpty();
        }

        private void txtPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPrincipal_Leave(sender, e);
        }

        private void txtPrincipal_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!Char.IsNumber(e.KeyValue.ToString()[0])) return;
            
            TextBox txt = (TextBox)sender;            
            char x = txt.Text[txt.SelectionStart];
            if (x.Equals('$'))
            {
                txt.SelectionStart++;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int length = int.Parse(txtPeriods.Text);
            float rate = float.Parse(txtGain.Text) / 100;
            decimal total = new decimal();

            if (chkAnnuity.Checked)
            {
                total += CalculateAnnuity(length, rate);
            }

            total += CalculatePrincipal(length);

            lblTotal.Text = total.ToString("C2");

            GenerateChart(length);
        }

        private decimal CalculateAnnuity(int length, float rate)
        {            
            //float rate = float.Parse(txtGain.Text) / 100;            
            int frequency = int.Parse(txtCompoundingFrequency.Text);

            decimal payment = decimal.Parse(txtAnnuityPayment.Text, NumberStyles.Currency);
            int immediately = chkPaymentAt.Checked ? 1 : 0;
            int paymentFrequency = int.Parse(txtPaymentFrequency.Text);
            float growth = float.Parse(txtPaymentGrowth.Text) / 100;

            if (growth == 0)
            {
                return FinanceCalculations.FutureFixedAnnuityValue(payment, length, rate, frequency, immediately, paymentFrequency);
            }
            else
            {
                return FinanceCalculations.FutureVariableAnnuityValue(payment, length, rate, growth, frequency, immediately, paymentFrequency);
            }
        }

        private decimal CalculatePrincipal(int length)
        {
            decimal principal = decimal.Parse(txtPrincipal.Text, NumberStyles.Currency);
            float rate = float.Parse(txtGain.Text) / 100;
            int frequency = int.Parse(txtCompoundingFrequency.Text);

            return FinanceCalculations.FutureValue(principal, length, rate, frequency);
        }

        private void GenerateChart(int length)
        {
            length++;
            float rate = float.Parse(txtGain.Text) / 100;
            decimal principal = decimal.Parse(txtPrincipal.Text, NumberStyles.Currency);
            decimal[] seriesAmount = new decimal[length];
            decimal[] paidAmount = new decimal[length];            

            for (int i = 0; i < length; i++)
            {
                seriesAmount[i] = CalculatePrincipal(i);
                paidAmount[i] = principal;

                if (chkAnnuity.Checked)
                {
                    seriesAmount[i] += CalculateAnnuity(i, rate);
                    paidAmount[i] += CalculateAnnuity(i, 0f);
                }                    
            }

            carcMain.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<decimal>(seriesAmount),
                    LabelPoint = point => point.Y.ToString("C2"),
                    Name = "Total",
                },

                new LineSeries
                {
                    Values = new ChartValues<decimal>(paidAmount),
                    LabelPoint = point => point.Y.ToString("C2"),
                    Name = "Saved",
                },                
            };

            carcMain.AxisX.Clear();
            carcMain.AxisY.Clear();

            carcMain.AxisX.Add 
            (
                new Axis
                {
                    Title = "Period"
                }
            );

            carcMain.AxisY.Add
            (
                new Axis
                {
                    Title = "Value"
                }
            );
        }        
    }
}