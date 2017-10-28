namespace _01.MatchFullName
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            //var input = Console.ReadLine().Split(new char[] { ' ', ',', }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string regex = @"\b([A-Z][a-z]+ [A-Z][a-z]+)\b";
            string input = Console.ReadLine();

            MatchCollection machNames = Regex.Matches(input, regex);

            foreach (Match name in machNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
