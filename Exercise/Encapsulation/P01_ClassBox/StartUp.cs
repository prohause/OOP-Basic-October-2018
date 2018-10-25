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

            try
            {
                var myBox = new Box(length, width, height);
                Console.WriteLine(myBox.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }
    }
}