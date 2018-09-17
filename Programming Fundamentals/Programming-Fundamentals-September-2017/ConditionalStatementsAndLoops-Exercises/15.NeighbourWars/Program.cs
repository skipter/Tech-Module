namespace NeighbourWars
{
    using System;
    public class Program
    {
        static void Main()
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int counter = 1;
           
            while (true)
            {
                if (counter % 2 == 1)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);
                    }
                } else if (counter % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth > 0)
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);
                    }
                }
                if (counter % 3 == 0 && goshoHealth > 0 && peshoHealth > 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                if (peshoHealth <= 0)
                {
                    Console.WriteLine("Gosho won in {0}th round.", counter);
                    break;
                } else if (goshoHealth <= 0)
                {
                    Console.WriteLine("Pesho won in {0}th round.", counter);
                    break;
                }
                counter++;
            }
        }
    }
}
