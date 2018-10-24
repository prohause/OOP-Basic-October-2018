using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            string[] content = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < content.Length; i += 2)
            {
                string currentType = content[i];
                long amount = long.Parse(content[i + 1]);

                string type = string.Empty;

                if (currentType.Length == 3)
                {
                    type = "Cash";
                }
                else if (currentType.ToLower().EndsWith("gem"))
                {
                    type = "Gem";
                }
                else if (currentType.ToLower() == "gold")
                {
                    type = "Gold";
                }

                if (type == "" || bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + amount)
                {
                    continue;
                }

                switch (type)
                {
                    case "Gem":
                        if (!bag.ContainsKey(type))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (amount > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[type].Values.Sum() + amount > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;

                    case "Cash":
                        if (!bag.ContainsKey(type))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (amount > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[type].Values.Sum() + amount > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(type))
                {
                    bag[type] = new Dictionary<string, long>();
                }

                if (!bag[type].ContainsKey(currentType))
                {
                    bag[type][currentType] = 0;
                }

                bag[type][currentType] += amount;
            }

            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}