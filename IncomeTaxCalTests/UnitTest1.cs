using IncomeTaxCal;
using NUnit.Framework;
using System;

namespace IncomeTaxCalTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetStateIncomeTax()
        {
            var incomeTax = new IncomeTaxCalFinder
            {
                State = "AL",
                Income = 45000
            };
            decimal expected = 0.04M;
            decimal actual = incomeTax.getStateIncomeTax();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestTaxableIncome()
        {
            var incomeTax = new IncomeTaxCalFinder
            {
                State = "AL",
                Income = 45000
            };
            decimal expected = 43200;
            decimal actual = incomeTax.taxableIncome();
            Assert.AreEqual(expected, actual);

            // If income is less then zero then this method will return zero
            try
            {
                var badIncomeTax = new IncomeTaxCalFinder
                {
                    State = "AL",
                    Income = -45000
                };
                Assert.Fail("Negative income should throw an exception.");

            }
            catch(ArgumentOutOfRangeException ar)
            {
                Assert.Pass("Negative income throws an exception.");
            }
            

        }

        [Test]
        public void InvalidState()
        {

        }

        // Test on making sure the dictonary input is correct. As in the Just two letters or no more then 50 where would be IncomeTaxCalFinder
    }
}