using System;

namespace P06_Sneaking
{
    internal class Sneaking
    {
        private static char[][] _room;

        private static void Main()
        {
            int rowCount = int.Parse(Console.ReadLine());
            _room = new char[rowCount][];

            for (int row = 0; row < rowCount; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                _room[row] = new char[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    _room[row][col] = input[col];
                }
            }

            var moves = Console.ReadLine().ToCharArray();
            int[] samPosition = new int[2];
            for (int row = 0; row < _room.Length; row++)
            {
                for (int col = 0; col < _room[row].Length; col++)
                {
                    if (_room[row][col] == 'S')
                    {
                        samPosition[0] = row;
                        samPosition[1] = col;
                    }
                }
            }
            foreach (var t in moves)
            {
                for (int row = 0; row < _room.Length; row++)
                {
                    for (int col = 0; col < _room[row].Length; col++)
                    {
                        switch (_room[row][col])
                        {
                            case 'b' when row >= 0 && row < _room.Length && col + 1 >= 0 && col + 1 < _room[row].Length:
                                _room[row][col] = '.';
                                _room[row][col + 1] = 'b';
                                col++;
                                break;

                            case 'b':
                                _room[row][col] = 'd';
                                break;

                            case 'd' when row >= 0 && row < _room.Length && col - 1 >= 0 && col - 1 < _room[row].Length:
                                _room[row][col] = '.';
                                _room[row][col - 1] = 'd';
                                break;

                            case 'd':
                                _room[row][col] = 'b';
                                break;

                            default:
                                break;
                        }
                    }
                }

                int[] getEnemy = new int[2];
                for (int j = 0; j < _room[samPosition[0]].Length; j++)
                {
                    if (_room[samPosition[0]][j] == '.' || _room[samPosition[0]][j] == 'S')
                    {
                        continue;
                    }

                    getEnemy[0] = samPosition[0];
                    getEnemy[1] = j;
                }
                if (samPosition[1] < getEnemy[1] && _room[getEnemy[0]][getEnemy[1]] == 'd' && getEnemy[0] == samPosition[0])
                {
                    _room[samPosition[0]][samPosition[1]] = 'X';
                    Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");
                    Print();
                }
                else if (getEnemy[1] < samPosition[1] && _room[getEnemy[0]][getEnemy[1]] == 'b' && getEnemy[0] == samPosition[0])
                {
                    _room[samPosition[0]][samPosition[1]] = 'X';
                    Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");
                    Print();
                }

                _room[samPosition[0]][samPosition[1]] = '.';
                switch (t)
                {
                    case 'U':
                        samPosition[0]--;
                        break;

                    case 'D':
                        samPosition[0]++;
                        break;

                    case 'L':
                        samPosition[1]--;
                        break;

                    case 'R':
                        samPosition[1]++;
                        break;

                    default:
                        break;
                }
                _room[samPosition[0]][samPosition[1]] = 'S';

                for (int j = 0; j < _room[samPosition[0]].Length; j++)
                {
                    if (_room[samPosition[0]][j] == '.' || _room[samPosition[0]][j] == 'S')
                    {
                        continue;
                    }

                    getEnemy[0] = samPosition[0];
                    getEnemy[1] = j;
                }

                if (_room[getEnemy[0]][getEnemy[1]] != 'N' || samPosition[0] != getEnemy[0])
                {
                    continue;
                }

                {
                    _room[getEnemy[0]][getEnemy[1]] = 'X';
                    Console.WriteLine("Nikoladze killed!");
                    Print();
                }
            }
        }

        private static void Print()
        {
            foreach (var t1 in _room)
            {
                foreach (var t2 in t1)
                {
                    Console.Write(t2);
                }

                Console.WriteLine();
            }
            Environment.Exit(0);
        }
    }
}