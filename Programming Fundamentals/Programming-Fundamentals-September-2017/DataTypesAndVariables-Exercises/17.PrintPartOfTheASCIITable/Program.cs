namespace _17.PrintPartOfTheASCIITable
{
    using System;
    public class Program
    {
        static void Main()
        {
            int charIndex = int.Parse(Console.ReadLine());
            int secondCharIndex = int.Parse(Console.ReadLine());

            char firstChar = Convert.ToChar(charIndex);
            char secondChar = Convert.ToChar(secondCharIndex);

            for (char i = firstChar; i <= secondChar; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
