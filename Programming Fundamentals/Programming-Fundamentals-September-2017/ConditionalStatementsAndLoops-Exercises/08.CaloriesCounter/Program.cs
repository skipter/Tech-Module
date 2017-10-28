namespace CaloriesCounter
{
    using System;
    public class Program
    {
        static void Main()
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            int counter = 0;

            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;

            int totalCalories = 0;
            while (counter != numberOfProducts)
            {
                string currentProduct = Console.ReadLine().ToLower();
                counter++;
                if (currentProduct == "cheese")
                {
                    totalCalories += cheese;
                }
                else if (currentProduct == "tomato sauce")
                {
                    totalCalories += tomatoSauce;
                }
                else if (currentProduct == "salami")
                {
                    totalCalories += salami;
                }
                else if (currentProduct == "pepper")
                {
                    totalCalories += pepper;
                } else
                {
                    // currentProduct = Console.ReadLine().ToLower();
                }
            }
            Console.WriteLine("Total calories: {0}", totalCalories);
        }
    }
}
