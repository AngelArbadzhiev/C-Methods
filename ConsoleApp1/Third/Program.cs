using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintHeaderFooter(input);
            for (int i = 0; i < input - 2; i++)
            {
                PrintMidlleRow(input);  
            }
            PrintHeaderFooter(input);
        }

        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n ));
        }

        static void PrintMidlleRow(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }

            Console.Write("-");
            Console.WriteLine();
        }
    }
}