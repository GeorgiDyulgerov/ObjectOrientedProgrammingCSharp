using Problem1Shapes.Interfaces;

namespace Problem1Shapes.Figure
{
   abstract class BasicShape:IShape
    {
        private int width;
        private int height;

       protected BasicShape(int width,int height)
       {
           this.Width = width;
           this.Height = height;
       }

       public int Width { get; set; }
       public int Height { get; set; }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

    }
}
