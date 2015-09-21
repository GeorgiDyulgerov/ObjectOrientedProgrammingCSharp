using System;
using Problem1Shapes.Interfaces;

namespace Problem1Shapes.Figure
{
    class Circle:IShape
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius { get; set; }
        public double CalculateArea()
        {
            return Math.PI*this.Radius*this.Radius;
        }

        public double CalculatePerimeter()
        {
            return 2*Math.PI*this.Radius;
        }
    }
}
