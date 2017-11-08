namespace _04.Anonymous_Cache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AnonymousCache
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            string inputData = Console.ReadLine();

            while (inputData != "thetinggoesskrra")
            {
                var tokensData = inputData
                    .Split(new char[] { '>', ' ', '-', '|', }, StringSplitOptions.RemoveEmptyEntries);

                if (tokensData.Length == 0)
                {
                    inputData = Console.ReadLine();
                }
                if (tokensData.Length == 1)
                {
                    if (data.ContainsKey(tokensData[0]))
                    {

                    }
                    else if (!data.ContainsKey(tokensData[0]))
                    {
                        data.Add(tokensData[0], new Dictionary<string, long>());
                    }
                }
                else if (tokensData.Length != 0 && tokensData.Length > 1)
                {
                    string dataKey = tokensData[0];
                    string currentData = tokensData[1];
                    long dataSize = long.Parse(tokensData[2]);
                    if (data.ContainsKey(dataKey))
                        if (!data.ContainsKey(dataKey))
                    {
                        data.Add(dataKey,new Dictionary<string, long>());
                        data[dataKey].Add(currentData, dataSize);
                    }
                    if (!data[dataKey].ContainsKey(currentData))
                    {
                        data[dataKey].Add(currentData, dataSize);
                    }
                    data[dataKey][currentData] = dataSize;
                }
                inputData = Console.ReadLine();
            }
            foreach (var dataBase in data.OrderBy(x => x.Value))
            {
                Console.WriteLine($"Data Set: {dataBase}, Total Size: {dataBase.Value}");
            }
        }
    }
}
