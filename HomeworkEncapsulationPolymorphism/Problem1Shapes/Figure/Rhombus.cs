namespace Problem1Shapes.Figure
{
    class Rhombus:BasicShape
    {  
        public Rhombus(int width, int height) : base(width, height)
        {
        }
        public override double CalculateArea()
        {
            return this.Width*this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 4 * this.Width;
        }


    }
}
