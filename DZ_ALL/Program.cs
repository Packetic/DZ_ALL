using System;

namespace DZ_ALL
{
    class Program
    {
        // 1
        /*
        static double Z(double x, double y)
        {
            if (x > y) return 5 * x + y;
            else if (x == y) return Math.Cos(x);
            else if (y - 10 < x && x < y) return -2 * Math.Sin(y);
            else return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Z(5, 5));
        }
        */

        // 2
        /*
        static void Main(string[] args)
        {
            int x, sum = 0, ans;
            Console.WriteLine("Input 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                sum += x;
            }
            ans = sum / 10;
            Console.Write("Average: ");
            Console.WriteLine(ans);
        }
        */

        // 3
        /*
        static void Main(string[] args)
        {
            int x, sum = 1; 
            double ans;
            Console.WriteLine("Input 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                sum *= x;
            }
            ans = Math.Pow(sum, 0.1);
            Console.Write("Average: ");
            Console.WriteLine(ans);
        }
        */

        // 4
        /*
        static double f(int a, int b)
        { return a * 2 + b / 5 + Math.Sin(a + b); }
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Input x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y: ");
            y = Convert.ToInt32(Console.ReadLine());
            double z = f(x, 0) + 2 * f(y, 1) + 2 * f(x, y);
            Console.WriteLine(z);
        }
        */

        // 5
        /*
        static double f(int x, int y)
        {
            if (x >= y) return 5 * x;
            else if (x < 0) return -2 * x;
            else return 0;
        }

        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Input x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y: ");
            y = Convert.ToInt32(Console.ReadLine());
            double z = 2 * f(x, y) + 4 * f(y, 1);
            Console.WriteLine(z);
        }
        */
    }
}
