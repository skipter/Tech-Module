namespace _03.Camera_View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class CameraView
    {
        public static void Main()
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            int toSkip = elements[0];
            int toTake = elements[1];
            string pattern = $"\\|\\<(.{{0,{toSkip}}})(.{{0,{toTake}}})";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            List<string> results = new List<string>();
            while (input.Length > match.Index + 2 && match.Success)
            {
                string matchToAdd = match.Groups[2].Value;

                if (matchToAdd.Contains("|"))
                {
                    matchToAdd = matchToAdd.Substring(0, matchToAdd.IndexOf("|"));
                }
                if (matchToAdd.Contains("<"))
                {
                    matchToAdd = matchToAdd.Substring(0, matchToAdd.IndexOf("<"));
                }
                results.Add(matchToAdd);

                input = input.Substring(match.Index + 2);
                match = regex.Match(input);
            }
            Console.WriteLine(String.Join(", ", results));

        }
    }
}
