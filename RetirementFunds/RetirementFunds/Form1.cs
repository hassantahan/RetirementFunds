using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (txtPrinciple.TextLength > 0 && txtEnterYears.TextLength > 0 && txtEnterInterest.TextLength > 0 && txtPeriods.TextLength > 0)
            {
                if (txtAnnuity.Enabled == false)
                {
                    btnCalculate.Enabled = true;
                }
                else if (txtAnnuity.TextLength > 0)
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

        private void txtPrinciple_KeyPress(object sender, KeyPressEventArgs e)
        {
            GarbageNonText(sender, e);
        }

        private void txtEnterYears_KeyPress(object sender, KeyPressEventArgs e)
        {
            GarbageNonText(sender, e);
        }

        private void txtEnterInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            GarbageNonText(sender, e);
        }

        private void txtAnnuity_KeyPress(object sender, KeyPressEventArgs e)
        {
            GarbageNonText(sender, e);
        }

        private void txtPrinciple_KeyUp(object sender, KeyEventArgs e)
        {
            CheckIfTextBoxEmpty();
        }

        private void txtEnterYears_KeyUp(object sender, KeyEventArgs e)
        {
            CheckIfTextBoxEmpty();
        }

        private void txtEnterInterest_KeyUp(object sender, KeyEventArgs e)
        {
            CheckIfTextBoxEmpty();
        }

        private void txtAnnuity_KeyUp(object sender, KeyEventArgs e)
        {
            CheckIfTextBoxEmpty();
        }

        private void chkAnnuity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnnuity.Checked)
            {
                txtAnnuity.Enabled = true;
                chkPaymentAt.Enabled = true;
            }
            else
            {
                txtAnnuity.Enabled = false;
                chkPaymentAt.Enabled = false;
            }

            CheckIfTextBoxEmpty();
        }

        private void txtPeriods_KeyPress(object sender, KeyPressEventArgs e)
        {
            GarbageNonText(sender, e);
        }

        private void txtPeriods_KeyUp(object sender, KeyEventArgs e)
        {
            CheckIfTextBoxEmpty();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal principle = decimal.Parse(txtPrinciple.Text);
            float gain = float.Parse(txtEnterInterest.Text) / 100;
            float length = float.Parse(txtEnterYears.Text);
            int periods = int.Parse(txtPeriods.Text);

            decimal fv = FinanceCalculations.FutureValue(principle, length, gain, periods);
            decimal pv = FinanceCalculations.PresentValue(principle, length, gain, periods);

            if (chkAnnuity.Checked)
            {
                decimal payment = decimal.Parse(txtAnnuity.Text);
                int immediately = chkPaymentAt.Checked ? 1 : 0;
                decimal afv = FinanceCalculations.FutureFixedAnnuityValue(payment, length, gain, periods, immediately);
                lblAnnuityFixed.Text = afv.ToString("C2");
            }

            lblFutureValue.Text = fv.ToString("C2");
            lblPresentValue.Text = pv.ToString("C2");
        }        
    }
}
