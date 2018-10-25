using P05_Pizza_Calories.Models;
using System;

namespace P05_Pizza_Calories
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(new[] { ' ' });
            Pizza myPizza;

            try
            {
                myPizza = new Pizza(tokens[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                var myDough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                myPizza.Dough = myDough;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    var myTopping = new Topping(tokens[1], double.Parse(tokens[2]));
                    myPizza.AddTopping(myTopping);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            Console.WriteLine($"{myPizza.Name} - {myPizza.Calories():f2} Calories.");
        }
    }
}