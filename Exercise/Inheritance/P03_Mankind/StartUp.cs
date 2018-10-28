using P03_Mankind.Models;
using System;

namespace P03_Mankind
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            try
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' });
                var firstName = tokens[0];
                var lastName = tokens[1];
                var number = tokens[2];

                var myStudent = new Student(firstName, lastName, number);

                tokens = Console.ReadLine().Split(new[] { ' ' });
                firstName = tokens[0];
                lastName = tokens[1];
                var weekSalary = decimal.Parse(tokens[2]);
                var hoursPerDay = decimal.Parse(tokens[3]);

                var myWorker = new Worker(firstName, lastName, weekSalary, hoursPerDay);

                Console.WriteLine(myStudent.ToString());
                Console.WriteLine();
                Console.WriteLine(myWorker.ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}