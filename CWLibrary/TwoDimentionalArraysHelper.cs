using System;

namespace CWLibrary
{
    public class TwoDimentionalArraysHelper
    {
        public static int MinElement(int[,] arr)
        {
            (int i, int j) = MinElementIndex(arr);

            return arr[i, j];
        }

        public static int MaxElement(int[,] arr)
        {
            (int i, int j) = MaxElementIndex(arr);

            return arr[i, j];
        }

        public static (int iMin, int jMin) MinElementIndex(int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Array is null or empty!");
            }
            int iMin = 0;
            int jMin = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[iMin, jMin])
                    {
                        iMin = i;
                        jMin = j;
                    }
                }
            }

            return (iMin, jMin);
        }

        public static (int iMax, int jMax) MaxElementIndex(int[,] arr)
        {
            int iMax = 0;
            int jMax = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[iMax, jMax])
                    {
                        iMax = i;
                        jMax = j;
                    }
                }
            }

            return (iMax, jMax);
        }
    }
}
