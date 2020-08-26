using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementFunds
{
    //This is a public static class that deals with specifically investment oriented calculations.
    //This includes a Monte-Carlo simulation, calculating real dollars, tax considerations, and 
    //customization when it comes to contribuitions.
    public static class Investing
    {
        public static int recurringInvestingFrequency = 1;

        private static double STOCK_RETURN = 0.075;
        private static double BOND_RETURN = 0.04;
        private static double TIME_STEP = 0.01;

        public static double PortfolioWeightedAverageReturn(double bondFraction, double stockFraction)
        {
            return bondFraction * BOND_RETURN + stockFraction * STOCK_RETURN;
        }


        // An interative function that finds the time to meet the goal.
        public static double GetTimeToGoal(decimal goal, decimal principal, decimal payment, double growth, double savingsGrowth)
        {
            double time = 0;
            decimal m = 0;

            while (m < goal)
            {
                m = 0;
                m += FinanceCalculations.FutureValue(principal, time, growth);

                if (savingsGrowth > 0)
                {
                    m += FinanceCalculations.FutureVariableAnnuityValue(payment, time, growth, savingsGrowth, 365, 0, Investing.recurringInvestingFrequency);
                }
                else
                {
                    m += FinanceCalculations.FutureFixedAnnuityValue(payment, time, growth, 365, 0, Investing.recurringInvestingFrequency);
                }

                time += TIME_STEP;
            }

            return time;
        }

        public static string CalculateGoal(double withdrawlRate, double taxRate, decimal retirementSpeding)
        {
            decimal goal = retirementSpeding * (decimal)((1 + taxRate) / withdrawlRate);

            return goal.ToString("C2");
        }
    }
}
