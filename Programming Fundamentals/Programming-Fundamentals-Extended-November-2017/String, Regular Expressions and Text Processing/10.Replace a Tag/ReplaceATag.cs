﻿namespace _10.Replace_a_Tag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceATag
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(text, pattern, replace);
                Console.WriteLine(replaced);
                text = Console.ReadLine();
            }
        }
    }
}
