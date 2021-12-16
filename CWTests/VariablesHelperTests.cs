using CWLibrary;
using NUnit.Framework;
using System;

namespace CWTests
{
    public class VariablesHelperTests
    {
        [TestCase(2, 3, 19)]
        [TestCase(3, 5, 20)]
        public void CalculateEquation_WhenANotEqualToB_ShouldCalculateEquation(
            double a,
            double b,
            double expectedResult)
        {
            double actualResult = VariablesHelper.CalculateEquation(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateEquation_WhenAEqualToB_ShouldThrowArgumentException()
        {
            try
            {
                VariablesHelper.CalculateEquation(1, 1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A equal to B!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}