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

namespace RetirementFunds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            if (txtPrincipal.TextLength > 0 && txtEnterYears.TextLength > 0 && txtEnterInterest.TextLength > 0 && txtPeriods.TextLength > 0)
            {
                if (txtAnnuity.Enabled == false)
                {
                    btnCalculate.Enabled = true;
                }
                else if (txtAnnuity.TextLength > 0 && txtPaymentFrequency.TextLength > 0 && txtPaymentGrowth.TextLength > 0)
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
                txtAnnuity.Enabled = true;
                txtPaymentFrequency.Enabled = true;
                txtPaymentGrowth.Enabled = true;
                chkPaymentAt.Enabled = true;
            }
            else
            {
                txtAnnuity.Enabled = false;
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal principal = decimal.Parse(txtPrincipal.Text, NumberStyles.Currency);
            float gain = float.Parse(txtEnterInterest.Text) / 100;
            float length = float.Parse(txtEnterYears.Text);
            int periods = int.Parse(txtPeriods.Text);

            decimal total = new decimal();

            if (chkAnnuity.Checked)
            {
                decimal payment = decimal.Parse(txtAnnuity.Text, NumberStyles.Currency);
                int immediately = chkPaymentAt.Checked ? 1 : 0;
                int frequencyOfPayments = int.Parse(txtPaymentFrequency.Text);
                float growth = float.Parse(txtPaymentGrowth.Text) / 100;

                decimal afv;

                if (growth == 0)
                {
                    afv = FinanceCalculations.FutureFixedAnnuityValue(payment, length, gain, periods, immediately, frequencyOfPayments);
                }
                else
                {
                    afv = FinanceCalculations.FutureVariableAnnuityValue(payment, length, gain, growth, periods, immediately, frequencyOfPayments);
                }

                total += afv;
            }

            total += FinanceCalculations.FutureValue(principal, length, gain, periods);

            lblAnnuityFixed.Text = total.ToString("C2");

        }        
    }
}