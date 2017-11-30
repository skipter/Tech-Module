namespace _05.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;
    public class MatchFullName
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();
        }
    }
}
