using System;

namespace P03_Mankind.Models
{
    internal class Worker : Human
    {
        private decimal _hoursPerDay;
        private decimal _weekSalary;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal hoursPerDay) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            HoursPerDay = hoursPerDay;
        }

        public decimal HoursPerDay
        {
            get => _hoursPerDay;
            set
            {
                if (value < 1 || 12 < value)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                _hoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get => _weekSalary;
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                _weekSalary = value;
            }
        }

        public decimal GetSalaryPerHour()
        {
            return WeekSalary / 5.0m / HoursPerDay;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\r\nWeek Salary: {WeekSalary:F2}" +
                   $"\r\nHours per day: {HoursPerDay:F2}" +
                   $"\r\nSalary per hour: {GetSalaryPerHour():F2}";
        }
    }
}