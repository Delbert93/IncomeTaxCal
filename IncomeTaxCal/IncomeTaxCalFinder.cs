using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Text;

namespace IncomeTaxCal
{
    public class IncomeTaxCalFinder
    {
        public string State { get; set; }
        public double TaxPercentage { get; set; }
        public double Income { get; set; }

        public string[] listOfStates = { "AL", "AK", "AZ", "AR"};

        public double[] stateTax = {0.04, 0.0621, 0.0334, 0.06};

        public IncomeTaxCalFinder()
        {}

        public IncomeTaxCalFinder(string state, double taxPercentage, int income)
        {
            State = state;
            TaxPercentage = taxPercentage;
            Income = income;
        }

        public double getStateIncomeTax()
        {
            int count = 0;
            foreach (string s in listOfStates)
            {
                if (s == State)
                {
                    TaxPercentage = stateTax[count];
                    break;
                }
                count++;
            }
            return TaxPercentage;
        }

        // READ!!!!!!!! I know the way i am checking for the income and lists is not great but i was not sure how to catch an error in a test if the income was 
        // bad. If you could leave a comment on a better way that would be great! If you dont ill schedule time
        // with you on it

        public double taxableIncome()
        {
            if (Income < 0)
            {
                return 0;
            }
            TaxPercentage = getStateIncomeTax();
            Income = Income - (TaxPercentage*Income);
            return Income;
           
        }

    }
}
