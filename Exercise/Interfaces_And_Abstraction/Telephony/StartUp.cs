using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            var phones = Console.ReadLine().Split(" ").ToList();
            var sites = Console.ReadLine().Split(" ").ToList();

            var myPhone = new Smartphone();

            phones.ForEach(p => myPhone.MakeCall(p));
            sites.ForEach(s => myPhone.SurfWeb(s));
        }
    }
}