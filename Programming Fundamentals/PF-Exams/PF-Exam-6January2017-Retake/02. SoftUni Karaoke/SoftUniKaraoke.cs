namespace _02.SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            //Save karaoke names
            var names = Console.ReadLine()
                .Split(new string[] { ", ", }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            //Save songs for karaoke
            var songs = Console.ReadLine()
                .Split(new string[] { ", ", }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            //Save for every single line, name, song/singer - name/ , int = number awards for name.
            Dictionary<string, List<string>> awards = new Dictionary<string, List<string>>();

            while (input != "dawn")
            {
                //Every new line - new Singer, song and award if have.
                var onStage = input
                .Split(new string[] { ", ", }
                , StringSplitOptions.RemoveEmptyEntries);

                var name = onStage[0];
                var song = onStage[1];
                var haveAward = onStage[2];

                if (names.Contains(name) && songs.Contains(song))
                {
                    if (!awards.ContainsKey(name))
                    {
                        awards.Add(name, new List<string>());
                    }

                    if (!awards[name].Contains(haveAward))
                    {
                        awards[name].Add(haveAward);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in awards.OrderByDescending(x => x.Value.Count).ThenBy(n => n.Key))
            {
                string singer = item.Key;
                List<string> data = item.Value;
                Console.WriteLine($"{singer}: {data.Count()} awards");

                foreach (var award in data.OrderBy(n => n))
                {
                    Console.WriteLine($"--{award}");
                }
            }
            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}