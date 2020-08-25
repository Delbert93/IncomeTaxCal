using System;

namespace IncomeTaxCal
{
    class Program
    {
        static void Main(string[] args)
        {
            var incomeTax = new IncomeTaxCalFinder
            {
                State = "AK",
                Income = 45000
            };
            incomeTax.taxableIncome();
            Console.WriteLine("Hello World!");
        }
    }
}
