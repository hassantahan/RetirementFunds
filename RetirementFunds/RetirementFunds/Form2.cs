using LiveCharts;
using LiveCharts.Wpf;
using Meta.Numerics.Statistics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

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
            txtSavingsGoal.Text = GetGoal();
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
            txtSavingsGoal.Text = GetGoal();
        }       

        private void chkInflationIncomeGrowthPeg_CheckedChanged(object sender, EventArgs e)
        {
            txtSavingsGoal.Text = GetGoal();
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
        
        // Receives the goal string from the Investing class after sending parameters
        private string GetGoal()
        {
            bool pegToInflation = chkInflationRetirementSpendingPeg.Checked;
            bool incomeGrowthExcessOfInflation = chkInflationIncomeGrowthPeg.Checked;

            double bondAllocation = double.Parse(txtBondFraction.Text) / 100;
            double stockAllocation = double.Parse(txtStockFraction.Text) / 100;
            double bReturns = double.Parse(txtBondReturns.Text) / 100;
            double sReturns = double.Parse(txtStockReturns.Text) / 100; 
            double withdrawlRate = double.Parse(txtWithdrawlRate.Text) / 100;
            double taxRate = double.Parse(txtTaxRate.Text) / 100;
            double inflation = double.Parse(txtInflation.Text) / 100;
            double incomeGrowthRate = double.Parse(txtIncomeGrowth.Text) / 100 + (incomeGrowthExcessOfInflation ? inflation : 0);
            double savingsGrowthRateFraction = double.Parse(txtSavingFractionGrowth.Text) / 100;
            
            double savingsGrowthRate = savingsGrowthRateFraction * incomeGrowthRate;
            double averageReturn = Investing.PortfolioWeightedAverageReturn(bondAllocation, stockAllocation, bReturns, sReturns);

            decimal initialSavings = decimal.Parse(txtIncome.Text, NumberStyles.Currency) - decimal.Parse(txtSpending.Text, NumberStyles.Currency);
            decimal spending = decimal.Parse(txtRetirementSpending.Text, NumberStyles.Currency);
            decimal currentInvestments = decimal.Parse(txtPrincipal.Text, NumberStyles.Currency);

            return Investing.CalculateGoal(withdrawlRate, taxRate, currentInvestments, spending, initialSavings, averageReturn, savingsGrowthRate, pegToInflation, inflation);
        }

        private void GenerateReturns()
        {
            // Set parameters
            bool incomeGrowthExcessOfInflation = chkInflationIncomeGrowthPeg.Checked;

            int projectionType = cboProjection.SelectedIndex;
            int paymentFrequency = Investing.recurringInvestingFrequency;            

            double bondAllocation = double.Parse(txtBondFraction.Text) / 100;
            double stockAllocation = double.Parse(txtStockFraction.Text) / 100;
            double inflationMean = double.Parse(txtInflation.Text) / 100;
            double incomeGrowthRate = double.Parse(txtIncomeGrowth.Text) / 100 + (incomeGrowthExcessOfInflation ? inflationMean : 0);
            double savingsGrowthRateFraction = double.Parse(txtSavingFractionGrowth.Text) / 100;
            double bReturns = double.Parse(txtBondReturns.Text) / 100;
            double sReturns = double.Parse(txtStockReturns.Text) / 100;            
            double savingsGrowthRate = savingsGrowthRateFraction * incomeGrowthRate;
            double time = 0;

            decimal currentInvestments = decimal.Parse(txtPrincipal.Text, NumberStyles.Currency);
            decimal initialSavings = decimal.Parse(txtIncome.Text, NumberStyles.Currency) - decimal.Parse(txtSpending.Text, NumberStyles.Currency);
            decimal goal = decimal.Parse(txtSavingsGoal.Text, NumberStyles.Currency);                                   

            carcInvestment.Series.Clear();            

            // 0 = fixed returns, 1 = monte-carlo; TODO: 2 = historical cycles
            if (projectionType == 0)
            {
                // Fixed Returns

                double averageReturn = Investing.PortfolioWeightedAverageReturn(bondAllocation, stockAllocation, bReturns, sReturns);
                double timeToRetire = Investing.GetTimeToGoal(goal, currentInvestments, initialSavings, averageReturn, savingsGrowthRate);

                decimal[] total = new decimal[(int)timeToRetire + 5];
                decimal[] returns = new decimal[(int)timeToRetire + 5];
                decimal[] principal = new decimal[(int)timeToRetire + 5];                               

                // Generate return arrays
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
                        total[i] += FinanceCalculations.FutureFixedAnnuityValue(initialSavings, i, averageReturn, 365, 0, paymentFrequency);
                        principal[i] += initialSavings * i;
                    }
                    returns[i] = total[i] - principal[i];
                }

                GenerateChart(total, "Total");
                GenerateChart(returns, "Return");
                GenerateChart(principal, "Principal", goal, timeToRetire);
                time = timeToRetire;
            }
            else if (projectionType == 1)
            {
                // Monte-Carlo

                int simulations = 50000;
                //double inflationVolatility = 0.0119;
                double stockVolatility = 0.21;
                double bondVolatility = 0.03;

                double[] percentileList = { 0.9, 0.75, 0.5, 0.25, 0.1 };
                double[] lengths = new double[simulations];
                double[] percentileLengths = new double[percentileList.Length];
                double[] averageRatesOfGrowth = new double[percentileList.Length];
                
                decimal[][] percentileReturns = new decimal[percentileList.Length][];

                //Run the simulations to find lengths
                for (int i = 0; i < simulations; i++)
                {
                    decimal x = currentInvestments;
                    Random r = new Random(DateTime.Now.Ticks.GetHashCode());
                    lengths[i] = 0;
                    while (x < goal)
                    {                        
                        // Randomly generated return of the portfolio
                        double pReturn = Investing.CalculateRandomPortfolioReturn(bReturns, bondVolatility, bondAllocation, sReturns, stockVolatility, stockAllocation, r);
                        
                        // Caluculate portfolio value at the end of the year
                        x *= 1 + (decimal)pReturn;

                        // Add savings to portfolio
                        if (savingsGrowthRate > 0)
                        {
                            x += FinanceCalculations.FutureValue(initialSavings, lengths[i], savingsGrowthRate, 1);
                        }
                        else
                        {
                            x += initialSavings * i;
                        }

                        lengths[i]++;
                    }                    
                }                

                for (int i = 0; i < percentileList.Length; i++) 
                {      
                    // Get length percentiles
                    percentileLengths[i] = FinanceCalculations.Percentile(lengths, percentileList[i]);

                    // Find equivelant growth rate
                    averageRatesOfGrowth[i] = Investing.GetRateOfGrowth(goal, currentInvestments, initialSavings, savingsGrowthRate, percentileLengths[i]);

                    // Initialize the array with the 90th percentile in length + 2
                    percentileReturns[i] = new decimal[(int)percentileLengths[0] + 2];

                    //Calculate return array
                    for (int j = 0; j < (int)percentileLengths[0] + 2; j++)
                    {
                        percentileReturns[i][j] += FinanceCalculations.FutureValue(currentInvestments, j, averageRatesOfGrowth[i], 365);

                        if (savingsGrowthRate > 0)
                        {
                            percentileReturns[i][j] += FinanceCalculations.FutureVariableAnnuityValue(initialSavings, j, averageRatesOfGrowth[i], savingsGrowthRate, 365, 0, paymentFrequency);
                        }
                        else
                        {
                            percentileReturns[i][j] += FinanceCalculations.FutureFixedAnnuityValue(initialSavings, j, averageRatesOfGrowth[i], 365, 0, paymentFrequency);
                        }
                    }                    
                }

                for (int i = 0; i < percentileLengths.Length; i++)
                {
                    int k = percentileList.Length - i - 1;
                    GenerateChart(percentileReturns[k], (100 * percentileList[i]).ToString("0") + "th Percentile Returns", goal, percentileLengths[2]);
                }

                time = percentileLengths[2];
            }

            PrintResults(time);
        }

        private void PrintResults(double time)
        {
            int currentAge = int.Parse(txtAge.Text);

            lblResults.Text = "It will take you " + time.ToString("0") + " years to reach your goal at age " + ((int)time + currentAge).ToString() + ".";
        }

        private void GenerateChart(decimal[] values, string name, decimal goal = 0, double time = 0)
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
                    Sections = new SectionsCollection
                    {
                        new AxisSection
                        {
                            Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(50, 168, 82)),
                            StrokeThickness = 2.5,
                            Value = time,
                            Opacity = 100,
                            //ToValue = (double)goal,
                        }
                    },
                }
            );

            carcInvestment.AxisY.Add
            (
                new Axis
                {
                    Title = "Value ($)",
                    LabelFormatter = val => val.ToString("C0"),
                    MinValue = double.Parse(txtPrincipal.Text, NumberStyles.Currency) * 0.999,
                    Sections = new SectionsCollection
                    {
                        new AxisSection
                        {
                            Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(50, 168, 82)),
                            StrokeThickness = 2.5,
                            //VisualElement = "Goal",
                            Value = (double)goal,
                            Opacity = 100,
                        }
                    },
                    
                }
            ) ;
        }

    }
}
