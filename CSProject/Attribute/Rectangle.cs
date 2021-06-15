using System;

namespace CSProject.Attribute
{
    [DebugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
    public class Rectangle
    {
        [field: DebugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
        // public double Length { get; }
        private readonly double m_length;

        [field: DebugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
        public double Width { get; }

        public Rectangle(double l, double w)
        {
            m_length = l;
            Width = w;
        }

        [DebugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]
        public double GetArea()
        {
            return m_length * Width;
        }

        [DebugInfo(56, "Zara Ali", "19/10/2012")]
        public void Display()
        {
            Console.WriteLine("Length: {0}", m_length);
            Console.WriteLine("Width: {0}", Width);
            // Console.WriteLine("Area: {0}", GetArea());
        }
    }
}