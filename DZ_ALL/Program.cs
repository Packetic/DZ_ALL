using System;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1

            /*
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.Write($"Hello, {name}");
            */

            // 2

            /*
            string n1, n2;
            decimal res;

            Console.Write("Input first number: ");
            n1 = Console.ReadLine();
            Console.Write("Input second number: ");
            n2 = Console.ReadLine();
            if (n2 == "0")
            { Console.WriteLine("Wrong n2!"); Environment.Exit(0); }

            res = Convert.ToDecimal(n1) / Convert.ToDecimal(n2);
            Console.WriteLine($"Result: {res}");
            */

            // 3

            /*
            string s = "";
            for (int i = 0; i < 10000; i++)
                s += ((char)i).ToString();
            Console.WriteLine("Number of symbol: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0 || n > 10000)
            { Console.WriteLine("Wrong Index!"); Environment.Exit(0); }
            Console.WriteLine(s[n]);
            */

            // 4

            /*
            int a, b, c, discr;
            Console.Write("Input a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input c: ");
            c = Convert.ToInt32(Console.ReadLine());
            discr = b * b + 4 * a * c;
            if (discr > 0)
            {
                double c1 = ((-b) + Math.Sqrt(discr)) / (2 * a);
                double c2 = ((-b) - Math.Sqrt(discr)) / (2 * a);
                Console.WriteLine($"first answer: {c1}");
                Console.WriteLine($"second answer: {c2}");
            }
            else if (discr == 0)
            { double c1 = (-b) / (2 * a); Console.WriteLine($"answer: {c1}"); }
            else Console.WriteLine("No answers.");
            */
        }
    }
}