using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var count = tokens[0];
            var intersections = tokens[1];
            var allRect = new List<Rectangle>();

            for (int i = 0; i < count; i++)
            {
                var elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var id = elements[0];
                var width = double.Parse(elements[1]);
                var height = double.Parse(elements[2]);
                var positionX = double.Parse(elements[3]);
                var positionY = double.Parse(elements[4]);

                allRect.Add(new Rectangle(id, width, height, positionX, positionY));
            }

            for (int i = 0; i < intersections; i++)
            {
                var elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstRect = elements[0];
                var secondRect = elements[1];

                if (!allRect.Any(p => p.GetId().Equals(firstRect)) ||
                    !allRect.Any(p => p.GetId().Equals(secondRect)))
                {
                    continue;
                }

                {
                    var intersects = allRect.First(p => p.GetId().Equals(firstRect))
                        .Intersects(allRect.First(p => p.GetId().Equals(secondRect)));
                    Console.WriteLine(intersects.ToString().ToLower());
                }
            }
        }
    }
}