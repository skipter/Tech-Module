namespace CakeIngredients
{
    using System;
    public class Program
    {
        static void Main()
        {
            string cakeProducts = Console.ReadLine();
            int counter = 0;

            while (cakeProducts != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", cakeProducts);
                cakeProducts = Console.ReadLine();
                counter++;
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", counter);
        }
    }
}
