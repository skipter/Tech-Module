namespace Choose_a_Drink
{
    using System;
    public class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            double productQuantity = double.Parse(Console.ReadLine());

            double waterPrice = 0.70;
            double coffeePrice = 1.00;
            double beerPrice = 1.70;
            double teaPrice = 1.20;
            double totalPrice = 0;

            switch (profession)
            {
                case "Athlete":
                    totalPrice = waterPrice * productQuantity;
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, totalPrice);
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalPrice = coffeePrice * productQuantity;
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, totalPrice);
                    break;
                case "SoftUni Student":
                    totalPrice = beerPrice * productQuantity;
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, totalPrice);
                    break;
                default:
                    totalPrice = teaPrice * productQuantity;
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, totalPrice);
                    break;
            }
        }
    }
}
