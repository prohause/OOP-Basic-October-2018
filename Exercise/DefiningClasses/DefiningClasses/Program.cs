using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var myFamily = new Family();
            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var newMember = new Person(name, age);
                myFamily.AddMember(newMember);
            }

            Console.WriteLine(myFamily.GetOldestMember());
        }
    }
}