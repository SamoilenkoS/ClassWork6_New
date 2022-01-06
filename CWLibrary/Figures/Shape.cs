using System;
using System.Collections.Generic;
using System.Text;

namespace CWLibrary.Figures
{
    public abstract class Shape
    {
        private double _a;
        private double _b;

        public string Name { get; set; }

        public double A
        {
            get
            {
                return _a;
            }
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

        public double B
        {
            get => _b;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("B should be greater than zero!");
                }
                if (value > 0)
                {
                    _b = value;
                }
            }
        }

        public Shape(double a, double b)
        {
            A = a;
            B = b;
        }

        public abstract double GetSomething();
    }
}
