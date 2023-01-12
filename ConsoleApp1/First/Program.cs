using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            PrintMidlle();
            Bottom();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintMidlle()
        {
            Console.WriteLine("Charged to __________________");
            Console.WriteLine("Received by _________________");
        }

        static void Bottom()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 GIKN");
        }
    }
}