using System;
using System.Linq;

namespace Abstraction
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            var rectangleInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var myRectangle = new Rectangle(new Point(rectangleInfo[0], rectangleInfo[1]),
                new Point(rectangleInfo[2], rectangleInfo[3]));

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var pointInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();

                var point = new Point(pointInfo[0], pointInfo[1]);

                Console.WriteLine(myRectangle.Contains(point));
            }
        }
    }
}