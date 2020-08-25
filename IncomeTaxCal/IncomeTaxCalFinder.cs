using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace IncomeTaxCal
{
    public class IncomeTaxCalFinder
    {
        public string State { get; set; }
        public double TaxPercentage { get; set; }
        public int Income { get; set; }

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
            string[] listOfStates = { "AL", "AK", "AZ", "AR" };
            double[] stateTax = { 0.04, 0.0621, 0.0334, 0.06 };
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

        public double taxableIncome()
        {
            TaxPercentage = getStateIncomeTax();
            double newIncome = Income - (TaxPercentage*Income);
            return newIncome;
        }
    }
}
