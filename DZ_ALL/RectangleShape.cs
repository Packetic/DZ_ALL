using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_6
{
    class RectangleShape : Shape
    {
        protected int Height { get; set; }
        private int Width { get; set; }
        public RectangleShape() { }
        public RectangleShape(int h, int w)
        {
            Height = h;
            Width = w;
        }
        protected override double GetArea() => Height * Width;
        public override string ToString()
        {
            string str = $"Height: {Height}, Width: {Width}, Area: {GetArea()}";
            return str;
        }
        public override void Print()
        { Console.WriteLine(ToString()); }
    }
}
