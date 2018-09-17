namespace _06.TriplesOfLatinLetters
{
    using System;
    public class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + number; i++)
            {
                for (char j = 'a'; j < 'a' + number; j++)
                {
                    for (char k = 'a'; k < 'a' + number; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");   
                    }
                }
            }
        }
    }
}
