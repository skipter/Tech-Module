namespace _04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Files
    {                                                           //70/100 Points
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> adresses = new List<string>();
            while (n > 0)
            {
                string adress = Console.ReadLine();
                adresses.Add(adress);
                n--;
            }

            string[] query = Console.ReadLine().Split(' ');
            string mod = query[0];
            string dir = query[2];

            List<string> temp = new List<string>();
            foreach (var adress in adresses)
            {
                if (adress.Contains(dir))
                {
                    temp.Add(adress);
                }
            }

            List<string> withModAndDir = new List<string>();
            foreach (var tem in temp)
            {
                if (tem.Contains(mod))
                {
                    withModAndDir.Add(tem);
                }
            }
            if (withModAndDir.Count <= 0)
            {
                Console.WriteLine("No");
            }
            Dictionary<string, int> final = new Dictionary<string, int>();
            foreach (var item in withModAndDir)
            {
                var fiki = item.Split(new char[] { ';', '\\' });
                foreach (var words in item)
                {
                    string modify = fiki[fiki.Length - 2];
                    int usage = int.Parse(fiki[fiki.Length - 1]);

                    if (!final.ContainsKey(modify))
                    {
                        final.Add(modify, usage);
                    }
                    final[modify] = usage;
                }
            }
            foreach (var fi in final.OrderByDescending(x => x.Value).ThenBy(g => g.Key))
            {
                Console.WriteLine($"{fi.Key} - {fi.Value} KB");
            }
        }
    }
}
