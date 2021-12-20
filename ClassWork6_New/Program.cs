using CWLibrary;
using System;

namespace ClassWork6_New
{
    class Program
    {
        static void SomeMethod()
        {
            throw new DivideByZeroException();
        }

        static int MoreThanAdjacentElementsCount(int[,] arr)
        {
            //try
            //{
            //    SomeMethod();
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Handle 1");
            //    throw;
            //}
            if(arr == null)
            {
                throw new ArgumentNullException();
            }
            int elementsCount = 0;
            int iLenght = arr.GetLength(0);
            int jLenght = arr.GetLength(1);

            for (int i = 0; i < iLenght; i++)
            {
                for (int j = 0; j < jLenght; j++)
                {
                    if (i == 0 || arr[i, j] > arr[i - 1, j])
                    {
                        if (i == iLenght - 1 || arr[i, j] > arr[i + 1, j])
                        {
                            if (j == 0 || arr[i, j] > arr[i, j - 1])
                            {
                                if (j == jLenght - 1 || arr[i, j] > arr[i, j + 1])
                                {
                                    ++elementsCount;
                                }
                            }
                        }
                    }
                }
            }

            return elementsCount;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void ReverseArrayByDiagonal(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i + 1; j < arr.GetLength(1); j++)
                {
                    Swap(ref arr[i, j], ref arr[j, i]);
                }
            }
        }

        static void Ex1()
        {
            int[,] arr = new int[,] { };
            try
            {
                var result = MoreThanAdjacentElementsCount(arr);
                Console.WriteLine(result);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.WriteLine("Finally");
            }

            Console.WriteLine("Finally!");
        }

        static void Ex2()
        {
            int[,] arr = new int[5, 5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = i * arr.GetLength(1) + j;
                }
            }

            Console.WriteLine(TwoDimentionalArraysHelper.MaxElement(arr));
        }

        static void Ex3()
        {
            Animal basya = new Animal();
            Animal bobik = new Animal();
            basya.Name = "Basya";
            bobik.Name = "Bobik";
            Animal[] animals = new Animal[2];
            animals[0] = basya;
            animals[1] = bobik;
            foreach (var animal in animals)
            {
                animal.SayMyName();
            }
        }

        static int Sum(int a, int b)
        {
            int result;
            try
            {
                checked
                {
                    result = a + b;
                }
            }
            catch (OverflowException)
            {
                throw;
            }

            return result;
        }

        static void Main(string[] args)
        {
            try
            {
                Sum(int.MaxValue, 1);
            }
            catch(OverflowException)
            {
                Console.WriteLine("Info for user!");//
            }
        }
    }
}
