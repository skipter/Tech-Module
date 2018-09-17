namespace _03.UnicodeCharacters
{
    using System;
    public class UnicodeCharacters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            string output = String.Empty;
            foreach (var charr in chars)
            {
                output += "\\u" + ((int)charr).ToString("X4");
            }
            Console.WriteLine(output.ToLower());
        }
    }
}
