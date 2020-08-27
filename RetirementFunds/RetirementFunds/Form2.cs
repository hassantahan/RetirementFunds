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
        public Form2()
        {
            InitializeComponent();
            cboProjection.SelectedIndex = 0;
            GenerateReturns();
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
            txtSavingsGoal.Text = Investing.CalculateGoal(double.Parse(txtWithdrawlRate.Text) / 100, double.Parse(txtTaxRate.Text) / 100, decimal.Parse(txtRetirementSpending.Text, NumberStyles.Currency));
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

            double savingsFraction = double.Parse(txtSavingFractionGrowth.Text);
            double spendingFraction = double.Parse(txtSpendingFractionGrowth.Text);

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

            double stockFraction = double.Parse(txtStockFraction.Text);
            double bondFraction = double.Parse(txtBondFraction.Text);

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

        private void Form2_Click(object sender, EventArgs e)
        {
            txtSavingsGoal.Text = Investing.CalculateGoal(double.Parse(txtWithdrawlRate.Text) / 100, double.Parse(txtTaxRate.Text) / 100, decimal.Parse(txtRetirementSpending.Text, NumberStyles.Currency));
            
        }       

        private void chkInflationIncomeGrowthPeg_CheckedChanged(object sender, EventArgs e)
        {
            txtSavingsGoal.Text = Investing.CalculateGoal(double.Parse(txtWithdrawlRate.Text) / 100, double.Parse(txtTaxRate.Text) / 100, decimal.Parse(txtRetirementSpending.Text, NumberStyles.Currency));
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
        }        
       
        private void GenerateReturns()
        {            
            int projectionType = cboProjection.SelectedIndex;
            int paymentFrequency = Investing.recurringInvestingFrequency;            

            double bondAllocation = double.Parse(txtBondFraction.Text) / 100;
            double stockAllocation = double.Parse(txtStockFraction.Text) / 100;
            double incomeGrowthRate = double.Parse(txtIncomeGrowth.Text) / 100;
            double savingsGrowthRateFraction = double.Parse(txtSavingFractionGrowth.Text) / 100;
            double bReturns = double.Parse(txtBondReturns.Text) / 100;
            double sReturns = double.Parse(txtStockReturns.Text) / 100;
            double averageReturn = Investing.PortfolioWeightedAverageReturn(bondAllocation, stockAllocation, bReturns, sReturns);

            decimal currentInvestments = decimal.Parse(txtPrincipal.Text, NumberStyles.Currency);
            decimal initialSavings = decimal.Parse(txtIncome.Text, NumberStyles.Currency) - decimal.Parse(txtSpending.Text, NumberStyles.Currency);
            decimal goal = decimal.Parse(txtSavingsGoal.Text, NumberStyles.Currency);            

            double savingsGrowthRate = savingsGrowthRateFraction * incomeGrowthRate;
            double timeToRetire = new double();

            // 0 = fixed returns, 1 = monte-carlo; TODO: 2 = historical cycles
            if (projectionType == 0)
            {
                //Fixed Returns
                timeToRetire = Investing.GetTimeToGoal(goal, currentInvestments, initialSavings, averageReturn, savingsGrowthRate);

                decimal[] total = new decimal[(int)timeToRetire + 5];
                decimal[] returns = new decimal[(int)timeToRetire + 5];
                decimal[] principal = new decimal[(int)timeToRetire + 5];                               

                for (int i = 0; i < (int)timeToRetire + 5; i++)
                {
                    principal[i] += currentInvestments;
                    total[i] += FinanceCalculations.FutureValue(currentInvestments, i, averageReturn, 365);
       
                    if (savingsGrowthRate > 0)
                    {
                        total[i] += FinanceCalculations.FutureVariableAnnuityValue(initialSavings, i, averageReturn, savingsGrowthRate, 365, 0, paymentFrequency);
                        principal[i] += FinanceCalculations.FutureVariableAnnuityValue(initialSavings, i, 0, savingsGrowthRate, 365, 0, paymentFrequency);
                    }
                    else
                    {
                        total[i] += FinanceCalculations.FutureFixedAnnuityValue(initialSavings, timeToRetire, averageReturn, 365, 0, paymentFrequency);
                        principal[i] += initialSavings * i;
                    }
                    returns[i] = total[i] - principal[i];
                }

                carcInvestment.Series.Clear();
                GenerateChart(total, "Total");
                GenerateChart(returns, "Return");
                GenerateChart(principal, "Principal");                
            }
            else if (projectionType == 1)
            {
                //Monte-Carlo
                int simulations = 10000;
                double stockVolatility = 0.204;
                double bondVolatility = 0.02;


                for (int i = 0; i < simulations; i++)
                {
                    do
                    {
                        
                    } while (true);
                }
            }

            PrintResults(timeToRetire);
        }

        private void PrintResults(double time)
        {
            int currentAge = int.Parse(txtAge.Text);

            lblResults.Text = "It will take you " + time.ToString("0.0") + "  to reach your goal at age " + ((int)time + currentAge).ToString() + ".";
        }

        private void GenerateChart(decimal[] values, string name)
        {
            int currentAge = int.Parse(txtAge.Text);            

            carcInvestment.Series.Add
            (
                new LineSeries
                {
                    Values = new ChartValues<decimal>(values),
                    LabelPoint = point => point.Y.ToString("C0"),
                    Title = name + ": ",
                }
            );

            carcInvestment.AxisX.Clear();
            carcInvestment.AxisY.Clear();

            carcInvestment.AxisX.Add
            (
                new Axis
                {
                    Title = "Years",
                    LabelFormatter = val => (val + currentAge).ToString(),
                }
            );

            carcInvestment.AxisY.Add
            (
                new Axis
                {
                    Title = "Value ($)",
                    LabelFormatter = val => val.ToString("C0"),
                    MinValue = double.Parse(txtPrincipal.Text, NumberStyles.Currency) * 0.999,
                }
            );
        }

    }
}
