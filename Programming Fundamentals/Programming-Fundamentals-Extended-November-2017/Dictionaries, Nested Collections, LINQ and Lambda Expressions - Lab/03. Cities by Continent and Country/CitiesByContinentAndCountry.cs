namespace _03.Cities_by_Continent_and_Country
{
    using System;
    using System.Collections.Generic;
    public class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> worldMap = new Dictionary<string, Dictionary<string, List<string>>>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string town = input[2];

                if (!worldMap.ContainsKey(continent))
                {
                    worldMap.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!worldMap[continent].ContainsKey(country))
                {
                    worldMap[continent][country] = new List<string>();
                }
                worldMap[continent][country].Add(town);
            }

            foreach (var continent in worldMap)
            {
                Console.WriteLine(continent.Key + ":");
                foreach (var countries in continent.Value)
                {
                    Console.Write($"{countries.Key} -> ");
                    Console.WriteLine(string.Join(", ", countries.Value));
                }
            }
        }
    }
}
