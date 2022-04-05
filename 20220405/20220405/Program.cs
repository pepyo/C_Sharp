using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            for (int i = 0; i < num; i++)
            {
                for (int j = num - 1; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
