using CWLibrary;
using CWLibrary.Figures;
using System;
using System.Collections;
using System.Collections.Generic;

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

        static CoordinateQuater GetCoordinateQuater(int x, int y)
        {
            CoordinateQuater result = CoordinateQuater.Axis;
            if(x > 0)
            {
                if(y > 0)
                {
                    result = CoordinateQuater.First;
                }
                else if(y < 0)
                {
                    result = CoordinateQuater.Second;
                }
            }
            else if(x < 0)
            {
                if(y > 0)
                {
                    result = CoordinateQuater.Third;
                }
                else if(y < 0)
                {
                    result = CoordinateQuater.Fourth;
                }
            }

            return result;
        }

        static double Convert(double sourceAmount, WeightUnits sourceUnits, WeightUnits destUnits)
        {
            return sourceAmount * (int)sourceUnits / (int)destUnits;
        }

        static void Ex4()
        {
            //Point point = new Point();
            //point.X = 10;
            //Console.WriteLine($"{point.X}:{point.Y}");
            //int sourceUnitsValue = 100;
            //WeightUnits sourceUnits = WeightUnits.Gram;
            //WeightUnits destUnits = WeightUnits.Kilogram;
            //double destValue = Convert(sourceUnitsValue, sourceUnits, destUnits);
            //Console.WriteLine(destValue);
            ////string testString = nameof(testString);
            //Console.WriteLine("Available colors:");
            ////Console.WriteLine($"Calling {nameof(GetCoordinateQuater)}");
            //var colors = Enum.GetValues(typeof(ConsoleColor));
            //foreach (var color in colors)
            //{
            //    Console.Write($"{color}\t");
            //}
            //Console.WriteLine((int)GetCoordinateQuater(10, 10));
        }

        static void Temp()
        {

            MyList myList = new MyList();
            myList.AddBack(1);
            myList.AddBack(5);
            myList.AddBack(4);
            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList[i]);
            }

            //Money a = new Money(10, 5);
            //Money b = new Money(5, 96);
            //Console.WriteLine(string.Format("{0} + {1} = {2}",
            //    a, b, a + b));
            //int coins = (int)a;
            //Console.WriteLine(coins);
            //  Console.WriteLine($"{a} + {b} = {a + b}");
        }

        static void Downcast()
        {
            object a = new Rectangle();
            if (a is Rectangle)
            {
                Rectangle r = a as Rectangle;
                Console.WriteLine(r.Square);
            }
        }

        static void Upcast()
        {
            Rectangle rectangle = new Rectangle();
            int a = 10;
            string test = "Hello world!";
            object[] elements = new object[] { rectangle, a, test };
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Shape[] shapes = new Shape[3];
            shapes[0] = new Rectangle(3, 4);
            shapes[2] = new Triangle(3, 4, 5);
            shapes[2].A = 3 * 4 * 5;
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape?.A);
                Console.Write(shape?.Name + "\t");
                Console.WriteLine(shape?.GetSomething());
            }

            //Rectangle r4;
            //Rectangle r1 = new Rectangle();
            //Rectangle r2 = new Rectangle((int)10.5);
            //Rectangle r3 = new Rectangle(10, 5);
            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            //Console.WriteLine(r3);
        }
    }
}
