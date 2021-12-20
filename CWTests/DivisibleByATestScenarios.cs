using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CWTests
{
    public class DivisibleByATestScenarios : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            var a1 = 20;
            var arrForA1 = new int[1_000 / a1];
            for (int i = a1, j = 0; i < arrForA1.Length; i += a1)
            {
                arrForA1[j++] = i;
            }

            yield return new object[] { a1, arrForA1 };
        }
    }
}
