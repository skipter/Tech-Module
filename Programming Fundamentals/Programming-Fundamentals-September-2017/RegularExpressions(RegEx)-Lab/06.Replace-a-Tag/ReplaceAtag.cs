namespace _06.Replace_a_Tag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceAtag
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            
            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(input, pattern, replace);

                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }
        }
    }
}
