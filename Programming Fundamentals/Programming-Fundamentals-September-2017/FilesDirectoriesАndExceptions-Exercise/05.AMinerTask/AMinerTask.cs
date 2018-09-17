namespace _05.AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class AMinerTasker
    {
        public static void Main()
        {
            string[] inLines = File.ReadAllLines("input.txt");
            File.Delete("output.txt");

            var resources = new Dictionary<string, double>();
            
            int materialIndex = 0;
            int quantityIndex = 1;
            
                while (inLines[materialIndex] != "stop")
                {
                Add(inLines[materialIndex], inLines[quantityIndex]);
                    materialIndex += 2;
                    quantityIndex += 2;
                }

                foreach (var pair in resources)
                {
                    string output = $"{pair.Key} -> {pair.Value}" + Environment.NewLine;
                    File.AppendAllText("output.txt", output);
                }
            
            void Add(string res, string quaintity)
            {
                if (!resources.ContainsKey(res))
                {
                    resources.Add(res, double.Parse(quaintity));
                }
                else
                {
                    resources[res] += double.Parse(quaintity);
                }
            }
        }
        
    }
}