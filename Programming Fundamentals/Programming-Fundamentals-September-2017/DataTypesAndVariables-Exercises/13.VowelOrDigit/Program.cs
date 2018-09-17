namespace _13.VowelOrDigit
{
    using System;
    public class Program
    {
        static void Main()
        {
            char symbol;
            symbol = Convert.ToChar(Console.ReadLine());
            bool isVowel = (symbol == 'a') || (symbol == 'e') || (symbol == 'i' || (symbol == 'o') || (symbol == 'u'));
            bool isDigit = (symbol >= '0') && (symbol <= '9');
            if (isVowel)
            {
                Console.WriteLine("vowel");
            } else if (isDigit)
            {
                Console.WriteLine("digit");
            } else
            {
                Console.WriteLine("other");
            }
        }
    }
}


