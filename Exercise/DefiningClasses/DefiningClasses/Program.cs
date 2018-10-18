using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var second = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var myTest = new DateModifier();
            myTest.CalculateDiff(DateTime.Parse(string.Join("/", first)), DateTime.Parse(string.Join("/", second)));
        }
    }
}