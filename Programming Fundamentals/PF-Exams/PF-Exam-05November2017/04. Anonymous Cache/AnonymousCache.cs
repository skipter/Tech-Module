namespace _04.Anonymous_Cache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AnonymousCache
    {
        public static void Main()                               // 90/100 Points - Missing Case
        {                           
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "thetinggoesskrra")
            {
                var commands = input.Split(new string[] { " -> ", " | ", "-", ">", "|", " ", }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (commands.Count == 0)
                {
                    input = Console.ReadLine();
                }
                if (commands.Count == 1)
                {
                    if (data.ContainsKey(commands[0]))
                    {

                    }
                    else if (!data.ContainsKey(commands[0]))
                    {
                        data.Add(commands[0], new Dictionary<string, long>());
                    }
                }
                else if (commands.Count != 1)
                {
                    string dataKey = commands[0];
                    long num = long.Parse(commands[1]);
                    string key = commands[2];

                    if (!data.ContainsKey(key))
                    {
                        data.Add(key, new Dictionary<string, long>());
                        data[key].Add(dataKey, num);
                    }
                    if (!data[key].ContainsKey(dataKey))
                    {
                        data[key].Add(dataKey, 0);
                    }
                    if (data[key].ContainsKey(dataKey))
                    {
                        data[key][dataKey] += num;
                    }
                    data[key][dataKey] = num;
                }

                input = Console.ReadLine();
            }
            if (data.Count == 0) return;
            if (data.Count > 0)
            {
                foreach (var item in data.OrderByDescending(x => x.Value.Values.Sum()))
                {
                    int count = 0;
                    if (count != 1)
                    {
                        Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");

                        foreach (var items in item.Value)
                        {
                            var dataBaseInput = items.Key;

                            Console.WriteLine($"$.{dataBaseInput}");
                        }
                        count++;
                        break;
                    }
                }
            }
        }
    }
}
