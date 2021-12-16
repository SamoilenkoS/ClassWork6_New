using System;
using System.Collections.Generic;
using System.Text;

namespace CWLibrary
{
    public class Rectangle
    {
        private double _a;
        private double _b;

        public Rectangle()
        {
            _a = 1;
            _b = 1;
        }

        public Rectangle(double a, double b)
        {
            if(a <= 0 || b <= 0)
            {
                throw new ArgumentException();
            }

            _a = a;
            _b = b;
        }

        public void SetA(double a)
        {
            if(a <= 0)
            {
                throw new ArgumentException("A should be greater than zero!");
            }
            if(a > 0)
            {
                _a = a;
            }
        }

        public void SetB(double b)
        {
            if (b > 0)
            {
                _b = b;
            }
        }

        public double GetSquare()
        {
            return _a * _b;
        }

        public double GetPerimetr()
        {
            return (_a + _b) * 2;
        }
    }
}
