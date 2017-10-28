namespace _02.IndexOfLetters
{
    using System;
    using System.IO;
    public class IndexOfLetters
    {
        public static void Main()
        {
            string[] words = File.ReadAllLines("input.txt");
            File.Delete("output.txt");

            foreach (var charr in words)
            {
                char[] alphabet = new char[26]
            { 'a', 'b', 'c', 'd', 'e', 'f', 'g','h', 'i', 'j', 'k', 'l','m', 'n',
                'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

                for (int i = 0; i < charr.Length; i++)
                {
                    char currentChar = charr[i];
                    string output = $"{currentChar} -> {Array.IndexOf(alphabet, currentChar)}\r\n";

                    File.AppendAllText("output.txt", output);
                }
            }
        }
    }
}