namespace RevisonSomething
{
    using System;
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            double nDevidedByTwo = n / 2.0;
            int pokeCounter = 0;

            while (n >= m)
            {
                if (n == nDevidedByTwo)
                {
                    if (y != 0)
                    {
                        n = n / y;
                    }
                    if (n >= m)
                    {
                        n -= m;
                        pokeCounter++;
                    }
                }
                else
                {
                    n -= m;
                    pokeCounter++;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(pokeCounter);
        }
    }
}