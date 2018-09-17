namespace _08.Match_Dates
{
    using System;
    using System.Text.RegularExpressions;
    public class MatchDates
    {
        public static void Main()
        {
            string pattern = @"\b(?<day>\d{2})(\W)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var input = Console.ReadLine();
            var dates = Regex.Matches(input, pattern);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
