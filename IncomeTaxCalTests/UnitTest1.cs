using IncomeTaxCal;
using NUnit.Framework;

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
            var badIncomeTax = new IncomeTaxCalFinder
            {
                State = "AL",
                Income = -45000
            };

            decimal badExpected = 0;
            decimal badActual = badIncomeTax.taxableIncome();
            Assert.AreEqual(badExpected, badActual);

        }
    }
}