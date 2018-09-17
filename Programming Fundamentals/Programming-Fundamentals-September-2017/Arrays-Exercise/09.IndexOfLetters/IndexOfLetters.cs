namespace _09.IndexOfLetters
{
    using System;
    public class IndexOfLetters
    {
        public static void Main()
        {
            string word = Console.ReadLine();

            char[] alphabet = new char[26] 
            { 'a', 'b', 'c', 'd', 'e', 'f', 'g','h', 'i', 'j', 'k', 'l','m', 'n',
                'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            
            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];
                Console.WriteLine($"{currentChar} -> {Array.IndexOf(alphabet, currentChar)}");
            }
        }
    }
}
