using System;
using System.Collections.Generic;
using System.Text;

namespace CWLibrary
{
    public class Rectangle
    {
        private static int _count;

        private double _a;
        private int _number;
        private readonly double _b;

        public static int Count => _count;

        public double A
        {
            get => _a;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A should be greater than zero!");
                }
                if (value > 0)
                {
                    _a = value;
                }
            }
        }

        public double Square => _a * _b;

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

        public Rectangle()
        {
            ++_count;
            _number = _count;
            _a = 1;
            _b = 1;
        }

        public Rectangle(double a, double b)
        {
            ++_count;
            _number = _count;
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException();
            }

            _a = a;
            _b = b;
        }

        public Rectangle(double _a)
        {
            this._a = _a;
        }

        public double GetPerimetr() => (_a + _b) * 2;

        //public static implicit operator double(Rectangle rectangle)
        //{
        //    return rectangle.Square;
        //}
        //+-*/
    }
}
