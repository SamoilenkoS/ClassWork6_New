using CWLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWTests
{
    public class LoopsHelperTests
    {
        [TestCase(3, 10, 7)]
        [TestCase(15, 1, 21)]
        [TestCase(1, 6, 0)]
        [TestCase(7, 14, 21)]
        [TestCase(7, 7, 7)]
        [TestCase(1, 1, 0)]
        [TestCase(6, 27, 42)]
        public void SumFromAToBWhichDivideBySeven_WhenAAndBPassed_ShouldCalculateSum(
            int a,
            int b,
            int expectedResult)
        {
            int actualResult = LoopsHelper.SumFromAToBWhichDivideBySeven(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
