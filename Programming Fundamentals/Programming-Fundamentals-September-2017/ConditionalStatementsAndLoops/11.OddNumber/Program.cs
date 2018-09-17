namespace OddNumber
{
    using System;
    public class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            while (number % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", Math.Abs(number));
        }
    }
}
