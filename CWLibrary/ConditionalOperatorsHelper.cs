using System;
using System.Collections.Generic;
using System.Text;

namespace CWLibrary
{
    public class ConditionalOperatorsHelper
    {
        public static int CalculateCondition(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }
    }
}
