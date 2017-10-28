namespace TriangleOfNumbers
{
    using System;
    public class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int col = 1; col <= number; col++)
            {
                for (int row = 1; row <= col - 1; row++) // Starts from 1 to col - 1 !!!
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine(col);
            }
        }
    }
}
