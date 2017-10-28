namespace _07.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class PopulationCounter
    {
        public static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                var inputArgs = input.Split('|');
                var city = inputArgs[0];
                var country = inputArgs[1];
                long population = long.Parse(inputArgs[2]);

                if (!data.ContainsKey(country))
                {
                    data.Add(country, new Dictionary<string, long>());
                    data[country].Add(city, population);
                }
               
                if (!data[country].ContainsKey(city))
                {
                    data[country].Add(city, 0);
                }
                data[country][city] = population;

                input = Console.ReadLine();
            }
            foreach (var item in data.OrderByDescending(x => x.Value.Values.Sum()))
            {
                var country = item.Key;
                Console.WriteLine("{0} (total population: {1})", country, item.Value.Values.Sum());

                foreach (var items in item.Value.OrderByDescending(p => p.Value))
                {
                    var city = items.Key;
                    long popUp = items.Value;
                    Console.WriteLine($"=>{city}: {popUp}");
                }
            }
        }
    }
}
