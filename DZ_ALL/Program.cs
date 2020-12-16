using System;

namespace DZ2
{
    public enum VUZ { MAI, MEI, SUAI, MSU, ITMO }
    public enum Types { current, credit, deposit, budget, soc }
    public struct BankAcc
    {
        public int number;
        public decimal balance;
        public Types type;
    }
    public struct Rab
    {
        public string surname;
        public string name;
        public decimal ZP;
        public VUZ vuz;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1

            /*
            Types t1 = Types.credit;
            Console.WriteLine(t1);
            */

            // 2

            /*
            BankAcc acc1;
            acc1.number = 1;
            acc1.balance = 212233554;
            acc1.type = Types.current;
            Console.WriteLine($"number: {acc1.number}");
            Console.WriteLine($"balance: {acc1.balance}");
            Console.WriteLine($"type: {acc1.type}");
            */

            // 3

            /*
            Rab rab1;
            rab1.name = "Andrey";
            rab1.surname = "Poklonsky";
            rab1.ZP = 500000;
            rab1.vuz = VUZ.SUAI;
            Console.WriteLine($"name: {rab1.name}");
            Console.WriteLine($"surname: {rab1.surname}");
            Console.WriteLine($"ZP: {rab1.ZP}");
            Console.WriteLine($"VUZ: {rab1.vuz}");
            */
        }
    }
}
