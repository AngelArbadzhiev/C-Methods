using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            PrintSign(input);
        }
        

        private static void PrintSign(double number)
        {
            if (number > 0 )
            {
                Console.WriteLine("positive");
            }
            else if (number < 0 )
            {
                Console.WriteLine("negative");
            }
            else if (number == 0)
            {
                Console.WriteLine("zero");
            }
        }
    }
}