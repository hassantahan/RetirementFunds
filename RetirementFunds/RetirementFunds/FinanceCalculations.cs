using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementFunds
{
    //A static class of the financial calculations present within the Retirement app.
    //Note: interest here does not only refer to interest, but any type of rate growth.
    static class FinanceCalculations
    {
        //Finds the future value of a sum of money principle after a set amount of time with a growth rate of interest
        //with the option to set the number of compounding periods in every unit of time.
        public static decimal FutureValue(decimal principle, float time, float interest, int nCompPeriods = 1)
        {
            return principle * (decimal)Math.Pow((1 + interest / nCompPeriods), time * nCompPeriods);
        }

        //The inverse of the FutureValue() method; i.e. given a future sum of money, what is the present worth.
        public static decimal PresentValue(decimal principle, float time, float interest, int nCompPeriods = 1)
        {
            return principle * (decimal)Math.Pow((1 + interest / nCompPeriods), -1 * time * nCompPeriods);
        }

        //For fixed annuities (i.e. static payments), this finds the future value. startImmediately is if the annuity starts  
        //at t=0 or one compound period after.
        public static decimal FutureFixedAnnuityValue(decimal annuity, float time, float interest, int nCompPeriods = 1, int startImmediately = 0)
        {
            return annuity / (decimal)interest * (decimal)(Math.Pow((1 + interest / nCompPeriods), time * nCompPeriods) - 1) * (decimal)(1 + interest / nCompPeriods * startImmediately);
        }

        //Finds the future value for an annuity where the annuity grows over time. Two different formulas if interest=growth or not.
        public static decimal FutureVariableAnnuityValue(decimal annuity, float time, float interest, float growth, int nCompPeriods = 1, int startImmediately = 0)
        {
            if (growth != interest)
            {
                return annuity / ((decimal)(interest - growth)) * (decimal)(Math.Pow((1 + interest / nCompPeriods), time * nCompPeriods) - Math.Pow((1 + growth / nCompPeriods), time * nCompPeriods)) *
                    (decimal)(1 + interest / nCompPeriods * startImmediately);
            }

            return annuity * (decimal)(nCompPeriods * time) * (decimal)(Math.Pow((1 + interest / nCompPeriods), time * nCompPeriods) - 1) * (decimal)(1 + interest / nCompPeriods * startImmediately);
        }
    }
}
