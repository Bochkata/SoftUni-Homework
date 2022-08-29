using System;
using System.Collections.Generic;
using System.Linq;

namespace T03LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> legendaryItems = new Dictionary<string, int>();
            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();

            legendaryItems.Add("shards", 0);
            legendaryItems.Add("fragments", 0);
            legendaryItems.Add("motes", 0);

            bool flag = false;

            while (true)
            {
                if (flag)
                {
                    break;
                }

                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i += 2)
                {

                    int quantity = int.Parse(input[i]);
                    string currentLegendaryOrJunkItem = input[i + 1].ToLower();

                    if (currentLegendaryOrJunkItem == "shards" || currentLegendaryOrJunkItem == "fragments"
                                                               || currentLegendaryOrJunkItem == "motes")
                    {
                        legendaryItems[currentLegendaryOrJunkItem] += quantity;
                    }
                    else
                    {

                        if (!junkItems.ContainsKey(currentLegendaryOrJunkItem))
                        {
                            junkItems.Add(currentLegendaryOrJunkItem, 0);
                        }

                        junkItems[currentLegendaryOrJunkItem] += quantity;
                    }

                    if (legendaryItems["shards"] >= 250 || legendaryItems["fragments"] >= 250
                                                        || legendaryItems["motes"] >= 250)
                    {
                        switch (currentLegendaryOrJunkItem)
                        {
                            case "shards":
                                Console.WriteLine("Shadowmourne obtained!");
                                legendaryItems[currentLegendaryOrJunkItem] -= 250;
                                break;
                            case "fragments":
                                Console.WriteLine("Valanyr obtained!");
                                legendaryItems[currentLegendaryOrJunkItem] -= 250;
                                break;
                            case "motes":
                                Console.WriteLine("Dragonwrath obtained!");
                                legendaryItems[currentLegendaryOrJunkItem] -= 250;
                                break;
                        }

                        flag = true;
                        break;
                    }

                }
            }

            foreach (KeyValuePair<string, int> item in legendaryItems.OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (KeyValuePair<string, int> item in junkItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }



        }
    }
}
