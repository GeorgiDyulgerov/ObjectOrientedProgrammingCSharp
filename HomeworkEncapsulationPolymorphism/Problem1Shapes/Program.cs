using System;
using System.Collections.Generic;
using System.Linq;
using Problem1Shapes.Figure;
using Problem1Shapes.Interfaces;

namespace Problem1Shapes
{
    class Program
    {
        static void Main()
        {
            List<IShape> shapes=new List<IShape>(){new Circle(5),new Rectangle(5,2),new Rhombus(6,5),new Rectangle(9,9),new Rhombus(9,9)};
            foreach (var shape in shapes)
            {
                Console.Write("-Type:{0}",shape.GetType());
                Console.Write("-Perimeter:{0:####.##}".PadLeft(25),shape.CalculatePerimeter());
                Console.WriteLine("-Area:{0:####.##}".PadLeft(30),shape.CalculateArea());
            }
        }
    }
}
