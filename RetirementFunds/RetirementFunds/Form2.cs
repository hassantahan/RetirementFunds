using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetirementFunds
{
    public partial class Form2 : Form
    {
        private float STOCK_RETURN = 0.075f;
        private float BOND_RETURN = 0.04f;

        public Form2()
        {
            InitializeComponent();
            cboProjection.SelectedIndex = 0;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormControlMethods.GarbageNonText(sender, e);
        }

        private void txtPrincipal_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            FormControlMethods.FixTextBoxCursor((TextBox)sender, e);
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            FormControlMethods.FormatTextBox((TextBox)sender);
        }

        private void txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormControlMethods.FormatTextBox((TextBox)sender);
                if (sender.Equals(txtIncome) || sender.Equals(txtSpending))
                {
                    txtIncome_Leave(sender, e);
                }
                else if (sender.Equals(txtSpendingFractionGrowth) || sender.Equals(txtSavingFractionGrowth))
                {
                    txtSpendingFractionGrowth_Leave(sender, e);
                }
                else if (sender.Equals(txtStockFraction) || sender.Equals(txtBondFraction))
                {
                    txtStockFraction_Leave(sender, e);
                }
            }            
        }

        private void txtSpendingFractionGrowth_Leave(object sender, EventArgs e)
        {
            FormControlMethods.FormatTextBox((TextBox)sender);

            float savingsFraction = float.Parse(txtSavingFractionGrowth.Text);
            float spendingFraction = float.Parse(txtSpendingFractionGrowth.Text);

            if (sender.Equals(txtSavingFractionGrowth))
            {
                spendingFraction = 100f - savingsFraction;
                txtSpendingFractionGrowth.Text = spendingFraction.ToString("0.0");
            }
            else
            {
                savingsFraction = 100f - spendingFraction;
                txtSavingFractionGrowth.Text = savingsFraction.ToString("0.0");
            }
        }

        private void txtStockFraction_Leave(object sender, EventArgs e)
        {
            FormControlMethods.FormatTextBox((TextBox)sender);

            float stockFraction = float.Parse(txtStockFraction.Text);
            float bondFraction = float.Parse(txtBondFraction.Text);

            if (sender.Equals(txtStockFraction))
            {
                bondFraction = 100f - stockFraction;
                txtBondFraction.Text = bondFraction.ToString("0.0");
            }
            else
            {
                stockFraction = 100f - bondFraction;
                txtStockFraction.Text = stockFraction.ToString("0.0");
            }
        }

        // Calculates the fraction that is being saved.
        private void txtIncome_Leave(object sender, EventArgs e)
        {
            FormControlMethods.FormatTextBox((TextBox)sender);

            decimal income = decimal.Parse(txtIncome.Text, NumberStyles.Currency);
            decimal spending = decimal.Parse(txtSpending.Text, NumberStyles.Currency);
            decimal savings = income - spending;

            txtSavings.Text = savings.ToString("C2") + " (" +  (savings / income * 100).ToString("0.0") + "%)";
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            GenerateReturns();
            GenerateChart();
        }

        private void GenerateReturns()
        {

        }

        private void GenerateChart()
        {
            carcInvestment.Series.Add
            (
                new LineSeries
                {
                    Values = new ChartValues<decimal>(),
                    LabelPoint = point => point.Y.ToString("C0"),
                    Title = "",
                }
            );
        }
    }
}
