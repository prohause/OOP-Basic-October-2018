using System;
using System.Linq;

namespace Working_with_Abstraction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {
                PrintRow(size, i);
            }

            for (int i = size - 1; i >= 1; i--)
            {
                PrintRow(size, i);
            }
        }

        private static void PrintRow(int size, int i)
        {
            Console.WriteLine($"{new string(' ', size - i)}{string.Join(" ", Enumerable.Repeat("*", i))}");
        }
    }
}