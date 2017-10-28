namespace _04.DrawAFilledSquare
{
    using System;
    public class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintHeaderRow(number);
            for (int i = 0; i < number - 2; i++)
            {
                PrintMiddleRow(number);
            }
            PrintHeaderRow(number);
        }
        static void PrintHeaderRow(int num)
        {
            Console.WriteLine(new string('-', num * 2));
        }
        static void PrintMiddleRow(int num)
        {
            Console.Write('-');
            for (int i = 1; i <= (2 * num-2)/2; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}
