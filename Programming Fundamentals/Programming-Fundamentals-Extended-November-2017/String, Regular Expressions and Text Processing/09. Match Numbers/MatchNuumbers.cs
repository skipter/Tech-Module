namespace _09.Match_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class MatchNuumbers
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var result = new List<string>();
            foreach (Match item in Regex.Matches(input, pattern))
            {
                result.Add(item.ToString());
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
