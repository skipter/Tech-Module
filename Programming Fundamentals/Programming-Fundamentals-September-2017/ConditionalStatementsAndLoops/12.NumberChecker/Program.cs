namespace NumberChecker
{
    using System;
    public class Program
    {
        static void Main()
        {
            try
            {
                var word = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
