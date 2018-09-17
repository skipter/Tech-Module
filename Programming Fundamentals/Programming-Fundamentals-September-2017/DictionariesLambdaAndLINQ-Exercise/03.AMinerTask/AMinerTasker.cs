namespace _03.AMinerTask
{
    using System;
    using System.Collections.Generic;
    public class AMinerTasker
    {
        public static void Main()
        {
            var resources = new Dictionary<string, double>();
            string input;
            
            while ((input = Console.ReadLine()) != "stop")
            {
                if (resources.ContainsKey(input))
                {
                    resources[input] += double.Parse(Console.ReadLine());
                }
                else
                {
                    resources[input] = double.Parse(Console.ReadLine());
                }
            }

            foreach (var pair in resources)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
