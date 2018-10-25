using System;

namespace P01_ClassBox
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var myBox = new Box(length, width, height);
            Console.WriteLine(myBox);
        }
    }
}