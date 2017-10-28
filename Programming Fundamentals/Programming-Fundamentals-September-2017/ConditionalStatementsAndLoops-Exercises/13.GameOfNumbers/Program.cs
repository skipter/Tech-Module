namespace GameOfNumbers
{
    using System;
    public class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magicNUmber = int.Parse(Console.ReadLine());

            int combinationsCounter = 0;
            bool isFOund = false;
            int c = 0;
            int d = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    if (i + j == magicNUmber)
                    {
                        isFOund = true;
                        c = i;
                        d = j;
                    }
                        combinationsCounter++;
                }
            }
            if (isFOund)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", c, d, magicNUmber);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combinationsCounter, magicNUmber);
            }
        }
    }
}
