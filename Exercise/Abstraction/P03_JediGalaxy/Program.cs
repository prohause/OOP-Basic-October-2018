using System;
using System.Linq;

namespace P03_JediGalaxy
{
    internal class Program
    {
        private static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowCount = dimensions[0];
            int columnCount = dimensions[1];

            int[,] matrix = new int[rowCount, columnCount];

            int value = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = value++;
                }
            }

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoStartPoint = command.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int[] evilStartPoint = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int evilPosX = evilStartPoint[0];
                int evilPosY = evilStartPoint[1];

                while (evilPosX >= 0 && evilPosY >= 0)
                {
                    if (evilPosX >= 0 && evilPosX < matrix.GetLength(0) && evilPosY >= 0 && evilPosY < matrix.GetLength(1))
                    {
                        matrix[evilPosX, evilPosY] = 0;
                    }
                    evilPosX--;
                    evilPosY--;
                }

                int ivoPosX = ivoStartPoint[0];
                int IvoPosY = ivoStartPoint[1];

                while (ivoPosX >= 0 && IvoPosY < matrix.GetLength(1))
                {
                    if (ivoPosX >= 0 && ivoPosX < matrix.GetLength(0) && IvoPosY >= 0 && IvoPosY < matrix.GetLength(1))
                    {
                        sum += matrix[ivoPosX, IvoPosY];
                    }

                    IvoPosY++;
                    ivoPosX--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}