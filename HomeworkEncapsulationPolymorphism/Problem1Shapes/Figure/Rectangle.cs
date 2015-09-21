namespace Problem1Shapes.Figure
{
    class Rectangle:BasicShape
    {    
        public Rectangle(int width, int height) : base(width, height)
        {
        }
        public override double CalculateArea()
        {
            return this.Width*this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2*this.Height + 2*this.Width;
        }

 
    }
}
