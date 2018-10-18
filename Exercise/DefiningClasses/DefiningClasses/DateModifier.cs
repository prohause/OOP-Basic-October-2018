using System;

namespace DefiningClasses
{
    internal class DateModifier
    {
        private TimeSpan diff;

        public void CalculateDiff(DateTime first, DateTime second)
        {
            diff = first - second;
            Console.WriteLine(Math.Abs(diff.TotalDays));
        }
    }
}