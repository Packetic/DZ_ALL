using System;

namespace DZ_5
{
    class Program
    {
        static void Main(string[] args)
        {
            BiSolver bi1 = new BiSolver();
            bi1.GetKoeffs();
            bi1.Solve();
            bi1.PrintRoots();
        }
    }
}
