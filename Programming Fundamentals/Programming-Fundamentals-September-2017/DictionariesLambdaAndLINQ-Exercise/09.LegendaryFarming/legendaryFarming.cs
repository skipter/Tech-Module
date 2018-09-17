namespace _09.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LegendaryFarming
    {
        public static void Main()
        {
            var keyMaterials = new Dictionary<string, int>() { ["motes"] = 0, ["fragments"] = 0, ["shards"] = 0 };
            var junkMaterials = new SortedDictionary<string, int>();
            var input = Console.ReadLine()
                .ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                int quantity = 0;
                var nameMaterial = String.Empty;

                for (int i = 0; i < input.Count; i += 2)
                {
                    quantity = int.Parse(input[i]);
                    nameMaterial = input[i + 1];

                    if (keyMaterials.ContainsKey(nameMaterial))
                    {
                        keyMaterials[nameMaterial] += quantity;
                        if (keyMaterials[nameMaterial] >= 250)
                        {
                            break;
                        }
                    }
                    else if (!junkMaterials.ContainsKey(nameMaterial))
                    {
                        junkMaterials.Add(nameMaterial, quantity);
                    }
                    else if (junkMaterials.ContainsKey(nameMaterial))
                    {
                        junkMaterials[nameMaterial] += quantity;
                    }
                }
                if (keyMaterials["shards"] >= 250 || keyMaterials["fragments"] >= 250 || keyMaterials["motes"] >= 250)
                {
                    if (keyMaterials["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                    }
                    else if (keyMaterials["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                    }
                    else
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                    }
                    keyMaterials[nameMaterial] -= 250;
                    foreach (var material in keyMaterials.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                    {
                        Console.WriteLine($"{material.Key}: {material.Value}");
                    }
                    foreach (var material in junkMaterials)
                    {
                        Console.WriteLine($"{material.Key}: {material.Value}");
                    }
                    return;
                }
                input = Console.ReadLine()
               .ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToList();
            }
        }
    }
}
