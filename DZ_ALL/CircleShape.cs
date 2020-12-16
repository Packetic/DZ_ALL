using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_6
{
    class CircleShape : Shape
    {
        private int Radius { get; set; }
        public CircleShape(int r)
        { Radius = r; }
        protected override double GetArea() => 2 * Math.PI * Radius;
        public override string ToString()
        {
            string str = $"Radius: {Radius}, Area: {GetArea()}";
            return str;
        }
        public override void Print()
        { Console.WriteLine(ToString()); }
    }
}
