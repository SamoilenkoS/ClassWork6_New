using System;
using System.Collections.Generic;
using System.Text;

namespace CWLibrary.Figures
{
    public class Triangle : Shape
    {
        public double C { get; set; }

        public Triangle(double a, double b, double c) : base(a, b)
        {
            Name = "Triangle";
            C = c;
        }

        public override double GetSomething()
        {
            return A * B * C;
        }
    }
}
