namespace _06.UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class UserLogs
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dict = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                var loginStats = input.Split(' ').ToList();

                var user = loginStats[2].Replace("user=", String.Empty);
                var ip = loginStats[0].Replace("IP=", String.Empty);
                var message = loginStats[1].Replace("message=", String.Empty); ;

                var counter = 1;

                if (!dict.ContainsKey(user))
                {
                    dict.Add(user, new Dictionary<string, int>());
                }

                if (!dict[user].ContainsKey(ip))
                {
                    dict[user].Add(ip, counter);
                }
                else
                {
                    dict[user][ip]++;
                }

                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                var user = item.Key;
                Console.WriteLine("{0}: ", item.Key);

                foreach (var userr in dict[user])
                {
                    var ip = userr.Key;
                    var count = userr.Value;
                    if (userr.Key != item.Value.Keys.Last())
                    {
                        Console.Write($"{ip} => {count}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ip} => {count}.");
                    }
                }
            }
        }
    }
}
