using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Text;

namespace IncomeTaxCal
{
    public class IncomeTaxCalFinder : ICloneable
    {
        public string State { get; set; }
        public decimal TaxPercentage { get; private set; }

        public decimal NewIncome { get; set; }
        public decimal Income 
        { 
            get => income; 
            set 
            { 
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Income), value, "Income can not be less then zero");
                }
                income = value; 
            } 
        }
        // TODO add the rest of the states and statetax
        public IEnumerable<string> ListOfStates => taxRates.Keys;

        public Dictionary<string, decimal> taxRates;
        private decimal income;

        public IncomeTaxCalFinder()
        {
            taxRates = new Dictionary<string, decimal>();
            taxRates.Add("AL", .04M);
            taxRates.Add("AK", .0621M);
            taxRates.Add("AZ", .0334M);
            taxRates.Add("AR", .06M);
        }

        public IncomeTaxCalFinder(string state, decimal taxPercentage, decimal income) : base()
        {
            State = state;
            TaxPercentage = taxPercentage;
            Income = income;
        }

        public decimal getStateIncomeTax()
        {
            return TaxPercentage = taxRates[State];
        }

        // READ!!!!!!!! I know the way i am checking for the income and lists is not great but i was not sure how to catch an error in a test if the income was 
        // bad. If you could leave a comment on a better way that would be great! If you dont ill schedule time
        // with you on it

        public decimal taxableIncome()
        {
            TaxPercentage = getStateIncomeTax();
            NewIncome = Income - (TaxPercentage * Income);
            return NewIncome;

        }

        public object Clone()
        {
            return new IncomeTaxCalFinder
            {
                Income = Income,
                TaxPercentage = TaxPercentage,
                State = State,
                NewIncome = NewIncome
            };
        }

    }
}
