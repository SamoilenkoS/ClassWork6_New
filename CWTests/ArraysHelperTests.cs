using CWLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWTests
{
    public class ArraysHelperTests
    {
        [TestCase(new int[] {}, new int[] {})]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 1, 5 }, new[] { 5, 1 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
        public void Reverse_WhenArrayNotNull_ShouldReverseArray(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArraysHelper.Reverse(sourceArray);

            Assert.AreEqual(expectedArray, sourceArray);
        }
    }
}
