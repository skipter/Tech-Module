using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p._7_Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int itemsToBuy = int.Parse(Console.ReadLine());

            double subTotal = 0.0;
            for (int i = 1; i <= itemsToBuy; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                subTotal += itemPrice;
             //   double secondItemPrice = itemPrice;
                int itemCount = int.Parse(Console.ReadLine());
                if (itemName.EndsWith("y"))
                {
                    itemName = itemName.Remove(itemName.Length - 1);
                    Console.WriteLine($"Adding {itemCount} {itemName + "ies"} to cart.");
                } else if (itemName.EndsWith("o") || itemName.EndsWith("s") || itemName.EndsWith("x") || itemName.EndsWith("z") || 
                    itemName.EndsWith("ch") ||itemName.EndsWith("sh"))
                {
                    Console.WriteLine($"Adding {itemCount} {itemName + "es"} to cart.");
                } else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName + "s"} to cart.");
                }
            }
            Console.WriteLine("Subtotal: ${0:F2}",subTotal);
            double moneyLeft = budget - subTotal;
            if (budget >= subTotal)
            {
                Console.WriteLine("Money left: ${0:F2}", moneyLeft);
            } else if (budget < subTotal)
            {
                Console.WriteLine("Not enough. We need ${0:F2} more.", Math.Abs(moneyLeft));
            }
        }
    }
}
