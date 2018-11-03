using System;

namespace Ferrari
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            var driver = Console.ReadLine();
            var myFerrari = new Ferrari(driver);
            Console.WriteLine($"{myFerrari.Model}/{myFerrari.UseBrakes()}/{myFerrari.PushGasPedal()}/{myFerrari.Driver}");
        }
    }
}