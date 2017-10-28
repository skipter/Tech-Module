namespace _03.PrintingTriangle
{
    using System;
    public class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                PrintLine(1, i);
            }
            PrintLine(1, number);

            for (int k = number - 1; k >= 0; k--)
            {
                PrintLine(1, k);
            }
        }
        static private void PrintLine(int start, int stop)
        {
            for (int k = start; k <= stop; k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }
    }
}
