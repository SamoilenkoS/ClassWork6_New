using CWLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWTests
{
    public class ConditionalOperatorsHelperTests
    {
        [TestCase(3, 10, -7)]
        [TestCase(5, 3, 8)]
        [TestCase(3, 3, 9)]
        public void CalculateCondition_WhenAAndBPassed_ShouldCalculateAAndB(
            int a,
            int b,
            int expectedResult)
        {
            int actualResult = ConditionalOperatorsHelper.CalculateCondition(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
