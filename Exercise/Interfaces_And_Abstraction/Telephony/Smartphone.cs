using System;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICallable, ISurfable
    {
        public void MakeCall(string number)
        {
            if (number.Any(c => !char.IsDigit(c)))
            {
                Console.WriteLine("Invalid number!");
                return;
            }
            Console.WriteLine($"Calling... {number}");
        }

        public void SurfWeb(string site)
        {
            if (site.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
                return;
            }
            Console.WriteLine($"Browsing: {site}!");
        }
    }
}