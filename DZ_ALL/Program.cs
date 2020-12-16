using System;

namespace DZ_6
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangleShape rect = new RectangleShape(35, 25);
            SquareShape square = new SquareShape(20);
            CircleShape circle = new CircleShape(10);

            rect.Print();
            square.Print();
            circle.Print();
        }
    }
}
