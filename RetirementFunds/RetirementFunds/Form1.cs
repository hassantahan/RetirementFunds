using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
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
            GenerateChart(int.Parse(txtPeriods.Text), float.Parse(txtCompoundingFrequency.Text));
            lblTotal.Text = "Final Value: " + CalculatePrincipal(int.Parse(txtPeriods.Text)).ToString("C2");
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
            int frequency = int.Parse(txtCompoundingFrequency.Text);
            decimal total = new decimal();

            if (chkAnnuity.Checked)
            {
                total += CalculateAnnuity(length, rate);
            }

            total += CalculatePrincipal(length);

            lblTotal.Text = "Final Value: " + total.ToString("C2");

            GenerateChart(length, (float)frequency);
        }

        // Method used to find the future value of the repeated payments.
        private decimal CalculateAnnuity(float length, float rate)
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

        // Method that is used to exclusivily find the future value of the principal.
        private decimal CalculatePrincipal(float length)
        {
            decimal principal = decimal.Parse(txtPrincipal.Text, NumberStyles.Currency);
            float rate = float.Parse(txtGain.Text) / 100;
            int frequency = int.Parse(txtCompoundingFrequency.Text);

            return FinanceCalculations.FutureValue(principal, length, rate, frequency);
        }

        // Generates the decimal arrays for the chart.
        private void GenerateChart(int length, float compounds)
        {
            length *= (int)compounds;
            length++;

            float rate = float.Parse(txtGain.Text) / 100;
            decimal principal = decimal.Parse(txtPrincipal.Text, NumberStyles.Currency);
            decimal[] seriesAmount = new decimal[length];
            decimal[] paidAmount = new decimal[length];            

            for (int i = 0; i < length; i++)
            {
                float f = i;
                seriesAmount[i] = CalculatePrincipal(f / compounds);
                paidAmount[i] = principal;

                if (chkAnnuity.Checked)
                {
                    seriesAmount[i] += CalculateAnnuity(f / compounds, rate);

                    // Different calculation for principal if growth in payments is 0.
                    float g = float.Parse(txtPaymentGrowth.Text, NumberStyles.Currency);
                    decimal payment = decimal.Parse(txtAnnuityPayment.Text, NumberStyles.Currency);
                    int payFreq = int.Parse(txtPaymentFrequency.Text);

                    if (g == 0f)
                    {
                        if (i != 0)
                        {
                            paidAmount[i] += payFreq / (int)compounds * payment * i;
                        }
                    }
                    else
                    {
                        paidAmount[i] += CalculateAnnuity(f / compounds, 0f);
                    }
                }                    
            }

            carcMain.Series.Clear();
            BuildChart(seriesAmount, "Total");
            BuildChart(paidAmount, "Principal");
        }
       
        private void BuildChart(decimal[] series, string name)
        {
            carcMain.Series.Add
            (
                new LineSeries
                {
                    Values = new ChartValues<decimal>(series),
                    LabelPoint = point => point.Y.ToString("C0"),
                    Title = name + ": ",
                }
            );

            carcMain.AxisX.Clear();
            carcMain.AxisY.Clear();

            carcMain.AxisX.Add
            (
                new Axis
                {
                    Title = "Compounding Periods"
                }
            );

            carcMain.AxisY.Add
            (
                new Axis
                {
                    Title = "Value ($)",
                    LabelFormatter = val => val.ToString("C0"),
                }
            ) ;
        }

        // Open Investing Form
        private void btnInvesting_Click(object sender, EventArgs e)
        {                        
            Form2 f2 = new Form2();                   
            f2.Show();
            Hide();
        }
    }
};