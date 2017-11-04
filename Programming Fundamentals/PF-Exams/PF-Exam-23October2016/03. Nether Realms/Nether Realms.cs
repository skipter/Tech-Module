namespace _03.Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine()
                .Split(new char[] { ' ', ',', }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            SortedDictionary<string, Dictionary<long, decimal>> sortedNames = new SortedDictionary<string, Dictionary<long, decimal>>();
            foreach (var name in names)
            {
                long health = 0;
                string healthPattern = @"([^0-9+\-\*/\.])";

                foreach (Match lettersMatch in Regex.Matches(name, healthPattern))
                {
                    health += Convert.ToChar(lettersMatch.Value);
                }

                decimal dmg = 0m;
                string damagePattern = @"(-?\d+(?:\.?\d+)?)";

                foreach (Match letter in Regex.Matches(name, damagePattern))//take num
                {
                    dmg += Convert.ToDecimal(letter.Value);
                }
                foreach (var symbol in name)
                {
                    if (symbol == '*')
                    {
                        dmg *= 2;
                    }
                    else if (symbol == '/')
                    {
                        dmg /= 2;
                    }
                }

                if (!sortedNames.ContainsKey(name))
                {
                    sortedNames.Add(name, new Dictionary<long, decimal>());
                }
                if (!sortedNames[name].ContainsKey(health))
                {
                    sortedNames[name].Add(health, 0);
                }
                sortedNames[name][health] = dmg;
            }

            foreach (var name in sortedNames)
            {
                foreach (var healthAndDmg in name.Value)
                {
                    Console.WriteLine($"{name.Key} - {healthAndDmg.Key} health, {healthAndDmg.Value:F2} damage");
                }
            }
        }
    }
}
