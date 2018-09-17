namespace _06.Mathc_Phone_Number
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(\+359([ |-])2\2\d{3}\2\d{4})\b";
            //string pattern2 = @"(\+[359]+)( )([0-9])( )([0-9]{3})( )([0-9]{4,4})\b";

            var phoneMatches = Regex.Matches(input, pattern);
            var matchedPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
