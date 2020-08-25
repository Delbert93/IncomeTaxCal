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
        public void TestTaxPercent()
        {
            var incomeTax = new IncomeTaxCalFinder
            {
                State = "AL",
                Income = 45000
            };
            double expected = 0.04;
            double actual = incomeTax.getStateIncomeTax();
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
            double expected = 43200;
            double actual = incomeTax.taxableIncome();
            Assert.AreEqual(expected, actual);
        }
    }
}