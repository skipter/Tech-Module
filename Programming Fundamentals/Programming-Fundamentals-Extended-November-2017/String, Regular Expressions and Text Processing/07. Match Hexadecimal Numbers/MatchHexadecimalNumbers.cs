namespace _07.Match_Hexadecimal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            List<string> result = new List<string>();
            foreach (Match m in Regex.Matches(input, pattern))
            {
                if (m.Value != String.Empty)
                {
                    result.Add(m.ToString());
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
