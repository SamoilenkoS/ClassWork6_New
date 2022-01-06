using CWLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWLibrary
{
    public class Rectangle : Shape
    {
        private static int _count;

        private int _number;

        public static int Count => _count;

        public double Square => A * B;

        public int this[string val]
        {
            get
            {
                if(val == "first")
                {
                    return 1;
                }
                else if(val == "second")
                {
                    return 2;
                }

                return 0;
            }
            set
            {
                
            }
        }

        public int Number => _number;

        static Rectangle()
        {
            _count = 0;
        }

        public Rectangle() : base(1, 1)
        {
            ++_count;
            _number = _count;
        }

        public Rectangle(double a, double b) : base(a, b)
        {
            Name = $"Rectangle{_count}";

            ++_count;
            _number = _count;
        }

        public double GetPerimetr() => (A + B) * 2;

        public override string ToString()
        {
            return $"{A}:{B}";
        }

        public override double GetSomething()
        {
            return A * B;
        }

        //public static implicit operator double(Rectangle rectangle)
        //{
        //    return rectangle.Square;
        //}
        //+-*/
    }
}
