namespace _03.Rage_Quit
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {                                                   //100/100 Point
            string karakacil = Console.ReadLine().ToUpper();
            HashSet<char> uniqueChars = new HashSet<char>();
            MatchCollection match = Regex.Matches(karakacil, @"([^0-9]+)(\d+)");
            //This regex catch everything except digits(firstGroup)(onlyDigits)
            StringBuilder sb = new StringBuilder();
            
            foreach (Match matchh in match)
            {
                string str = matchh.Groups[1].Value;
                int count = int.Parse(matchh.Groups[2].Value);
                while (count > 0)
                {
                    sb.Append(str);
                    count--;
                }
            }
            
            string gandalf = sb.ToString();
            foreach (var letter in gandalf)
            {
                if (!Char.IsDigit(letter))
                {
                    uniqueChars.Add(letter);
                }
            }
            Console.WriteLine($"Unique symbols used: {uniqueChars.Count}");
            Console.WriteLine(sb.ToString());
        }
    }
}
