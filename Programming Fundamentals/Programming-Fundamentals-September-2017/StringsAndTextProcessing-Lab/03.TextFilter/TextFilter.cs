namespace _03.TextFilter
{
    using System;
    using System.Linq;

    public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new char[] { ' ', ',', }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string textToCheck = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                if (textToCheck.Contains(bannedWord))
                {
                    string format = new string('*', bannedWord.Length);
                    textToCheck = textToCheck.Replace(bannedWord, format);
                }
            }
            Console.WriteLine(textToCheck);
        }
    }
}
