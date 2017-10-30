namespace _06.Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {                                                   //Not finished !
            var inputUsers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '/', '\\', '(', ')', }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var usernames = new List<string>();

            foreach (var user in inputUsers)
            {
                char[] userChars = user.ToCharArray();
                char firstChar = userChars[0];
                string pattern = @"([a-zA-Z0-9_]{4,25}+)";
                Regex regex = new Regex(pattern);
                bool isCorrectUser = user.Length > 3 && user.Length < 25 && Char.IsLetter(firstChar) && regex.IsMatch(user);
;                if (isCorrectUser)
                {
                    usernames.Add(user);
                }
            }
            Console.WriteLine(String.Join(", ", usernames));
        }
    }
}
