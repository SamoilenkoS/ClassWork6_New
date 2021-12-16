using System;
using System.Collections.Generic;
using System.Text;

namespace CWLibrary
{
    public class ArraysHelper
    {
        public static void Reverse(int[] array)
        {
            if(array == null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < array.Length / 2; i++)
            {
                VariablesHelper.Swap(ref array[i], ref array[array.Length - 1 - i]);
            }
        }
    }
}
