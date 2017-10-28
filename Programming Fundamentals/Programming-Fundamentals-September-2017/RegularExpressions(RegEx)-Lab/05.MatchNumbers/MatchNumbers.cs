namespace _05.MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchNumbers
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var nums = Regex.Matches(numbers, pattern);

            foreach (Match num in nums)
            {
                Console.Write(num.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
