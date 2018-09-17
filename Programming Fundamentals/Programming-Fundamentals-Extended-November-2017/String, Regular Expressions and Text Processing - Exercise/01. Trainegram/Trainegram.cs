namespace _01.Trainegram
{
    using System;
    using System.Text.RegularExpressions;
    public class Trainegram
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"^(<\[[^A-Za-z0-9\n]*]\.)(\.\[[A-Za-z0-9]*]\.)*$";

            while (input != "Traincode!")
            {
                //Regex regex = new Regex();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
