using System;
using System.Collections.Generic;
using System.Text;

namespace CWLibrary
{
    public class VariablesHelper
    {
        public static double CalculateEquation(double a, double b)
        {
            if(a == b)
            {
                throw new ArgumentException("A equal to B!");
            }

            return (5 * a + b * b) / (b - a);
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
