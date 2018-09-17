namespace _03.Poke_Mon
{
    using System;
    public class PokeMon
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int counter = 0;
            double divide = n / 2.0;
            while (n >= m)
            {
                if (n == divide)
                {
                    if (y != 0)
                    {
                        n = n / y;
                    }
                    if (n >= m)
                    {
                        n -= m;
                        counter++;
                    }
                }
                else
                {
                    n -= m;
                    counter++;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}
