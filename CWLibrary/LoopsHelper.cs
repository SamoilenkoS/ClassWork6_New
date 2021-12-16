using System;
using System.Collections.Generic;
using System.Text;

namespace CWLibrary
{
    public class LoopsHelper
    {
        public static int SumFromAToBWhichDivideBySeven(int a, int b)
        {
            if(a > b)
            {
                VariablesHelper.Swap(ref a, ref b);
            }

            int divider = 7;
            a += (divider - a % divider) % divider;
            int sum = 0;
            for (int i = a; i <= b; i += divider)
            {
                sum += i;
            }

            return sum;
        }
    }
}
