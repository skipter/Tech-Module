using System;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"([\w.-]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";
            Regex regex = new Regex(pattern);

            MatchCollection emailCollect = regex.Matches(input);

            foreach (Match email in emailCollect)
            {
                string emails = email.ToString();   
                
                if (!(emails.StartsWith(".") || emails.StartsWith("-") || emails.StartsWith("_") || 
                    emails.EndsWith("-") || emails.EndsWith(".") || emails.EndsWith("_")))
                {
                    Console.WriteLine(email);
                }
            }
        }
    }
}
