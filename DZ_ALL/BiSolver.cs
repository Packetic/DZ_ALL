using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DZ_5
{
    class BiSolver
    {
        private string aStr, bStr, cStr;
        private int a, b, c;
        private string x1 = "No value", x2 = "No value", x3 = "No value", x4 = "No value";

        public void GetKoeffs()
        {
            Console.WriteLine("Enter a: ");
            aStr = Console.ReadLine();
            while (!Microsoft.VisualBasic.Information.IsNumeric(aStr))
            { Console.WriteLine("Incorrect Input. Please, try again:"); aStr = Console.ReadLine(); }
            a = Convert.ToInt32(aStr);

            Console.WriteLine("Enter b: ");
            bStr = Console.ReadLine();
            while (!Microsoft.VisualBasic.Information.IsNumeric(bStr))
            { Console.WriteLine("Incorrect Input. Please, try again"); bStr = Console.ReadLine(); }
            b = Convert.ToInt32(bStr);

            Console.WriteLine("Enter c: ");
            cStr = Console.ReadLine();
            while (!Microsoft.VisualBasic.Information.IsNumeric(cStr))
            { Console.WriteLine("Incorrect Input. Please, try again"); cStr = Console.ReadLine(); }
            c = Convert.ToInt32(cStr);

            Console.WriteLine(" ");
        }
        public void Solve()
        {
            int discr = b * b - 4 * a * c;
            double t1, t2;
            if (discr < 0)
            {
                Console.WriteLine("No roots :(");
            }
            else if (discr == 0)
            {
                t1 = (b * (-1)) / (2 * a);
                x1 = Convert.ToString(Math.Sqrt(t1));
                x2 = Convert.ToString(Math.Sqrt(t1) * (-1));
            }
            else
            {
                t1 = (b * (-1) + Math.Sqrt(discr)) / (2 * a);
                t2 = (b * (-1) - Math.Sqrt(discr)) / (2 * a);

                if (t1 > 0)
                {
                    x1 = Convert.ToString(Math.Sqrt(t1));
                    x2 = Convert.ToString(Math.Sqrt(t1) * (-1));
                }
                else if (t1 == 0) x1 = "0";
                if (t2 > 0)
                {
                    x3 = Convert.ToString(Math.Sqrt(t2));
                    x4 = Convert.ToString(Math.Sqrt(t2) * (-1));
                }
                else if (t2 == 0) x3 = "0";
            }
        }
        public void PrintRoots()
        {
            if (x1 == "No value") Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"x1: {x1}");

            if (x2 == "No value") Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"x2: {x2}");

            if (x3 == "No value") Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"x3: {x3}");

            if (x4 == "No value") Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"x4: {x4}");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}