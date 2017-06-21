namespace Listing2_51_ASquareClassThatInheritsFromRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private class Square : Rectangle
        {
            public Square(int size) : base(size, size)
            {

            }

            public override int Width
            {
                get { return base.Width; }
                set
                {
                    base.Width = value;
                    base.Height = value;
                }
            }

            public override int Height
            {
                get
                {
                    return base.Height;
                }

                set
                {
                    base.Width = value;
                    base.Height = value;
                }
            }
        }

        class Rectangle
        {
            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public virtual int Height { get; set; }
            public virtual int Width { get; set; }

            public int Area
            {
                get { return Height * Width; }
            }
        }
    }
}
