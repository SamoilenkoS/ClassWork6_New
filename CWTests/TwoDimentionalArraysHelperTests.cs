using CWLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWTests
{
    public class TwoDimentionalArraysHelperTests
    {
        [TestCaseSource(nameof(MinCases))]
        public void Min_WhenArrayIsFilled_ShouldReturnMinFromArray(
            int[,] sourceArray,
            int expectedMin)
        {
            int actualMin = TwoDimentionalArraysHelper.MinElement(sourceArray);

            Assert.AreEqual(expectedMin, actualMin);
        }

        static object[] MinCases = new[]
        {
            new object[] { new[,] { { 1, 2, 3 }, { 4, 5, 6} }, 1 },
            new object[] { new[,] { { 4, 5, 6}, { 6, 7, 8} }, 4 }
        };

        [TestCaseSource(typeof(MaxArrayTestsScenarios))]
        public void Max_WhenArrayIsFilled_ShouldReturnMaxFromArray(
            int[,] sourceArray,
            int expectedMax)
        {
            int actualMax = TwoDimentionalArraysHelper.MaxElement(sourceArray);

            Assert.AreEqual(expectedMax, actualMax);
        }
    }
}
