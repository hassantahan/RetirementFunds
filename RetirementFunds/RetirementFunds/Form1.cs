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
using System.Windows;
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
            carcMain.Series = new SeriesCollection();
            GenerateChart(int.Parse(txtPeriods.Text));
            lblTotal.Text = CalculatePrincipal(int.Parse(txtPeriods.Text)).ToString("C2");
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
        }

        private void txtPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormControlMethods.GarbageNonText(sender, e);
        }

        private void txtPrincipal_Leave(object sender, EventArgs e)
        {            
            FormControlMethods.FormatTextBox((TextBox)sender);
        }

        private void txtPrincipal_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                FormControlMethods.FormatTextBox((TextBox)sender);
            }                
        }

        private void txtPrincipal_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            FormControlMethods.FixTextBoxCursor((TextBox)sender, e);
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

            carcMain.Series.Clear();
            BuildChart(seriesAmount);
            BuildChart(paidAmount);
        }

        private void BuildChart(decimal[] series)
        {
            carcMain.Series.Add
            (
                new LineSeries
                {
                    Values = new ChartValues<decimal>(series),
                    LabelPoint = point => point.Y.ToString("C2"),
                }
            );

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

        private void btnInvesting_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }
    }
};