namespace _02.Anonymous_Vox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class AnonymousVox
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<string> placeHolders = Console.ReadLine()
                .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList(); //Split("{}".ToCharArray()) - в кавичките може всичко и го разбира на чарове

            //Second way to Split the input .
            //string[] placeHolders = Regex.Split(Console.ReadLine(), "[{}]")
            //    .Where(x => x != String.Empty).ToArray();

            string patternOne = @"([a-zA-Z]+)(.*)(\1)";

            MatchCollection match = Regex.Matches(input, patternOne);
            int counter = 0;
            foreach (Match m in match)
            {
                string newString = m.Groups[1] + placeHolders[counter++] + m.Groups[3];
                input = input.Replace(m.Value, newString);
            }
            Console.WriteLine(input);
        }
    }
}
