using P04_Shopping_Spree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Shopping_Spree
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            var persons = new List<Person>();
            var products = new List<Product>();

            var tokens = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tokens.Length; i += 2)
            {
                try
                {
                    persons.Add(new Person(tokens[i], double.Parse(tokens[i + 1])));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            tokens = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tokens.Length; i += 2)
            {
                try
                {
                    products.Add(new Product(tokens[i], double.Parse(tokens[i + 1])));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentPerson = persons.First(p => p.Name == tokens[0]);
                var currentProduct = products.First(p => p.Name == tokens[1]);

                currentPerson.BuyProduct(currentProduct);
            }

            persons.ForEach(Console.WriteLine);
        }
    }
}