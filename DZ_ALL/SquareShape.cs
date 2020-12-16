using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_6
{
    class SquareShape : RectangleShape
    {
        public SquareShape(int h)
        { Height = h; }
        protected override double GetArea() => Height * Height;
        public override string ToString()
        {
            string str = $"Side: {Height}, Area: {GetArea()}";
            return str;
        }
        public override void Print()
        { Console.WriteLine(ToString()); }
    }
}
