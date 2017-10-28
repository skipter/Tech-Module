namespace Restaurant_Discount
{
    using System;
    public class Program
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string restaurantPackage = Console.ReadLine();

            string place = String.Empty;
            int placePrice = 0;
            int smallHall = 2500;
            int terrace = 5000;
            int greatHall = 7500;

            if (groupSize > 0 && groupSize <= 50)
            {
                place = "Small Hall";
                placePrice = smallHall;
            } else if (groupSize > 50 && groupSize <= 100)
            {
                place = "Terrace";
                placePrice = terrace;
            } else if (groupSize > 100 && groupSize <= 120)
            {
                place = "Great Hall";
                placePrice = greatHall;
            } else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            int packagePrice = 0;
            double discount = 0;
            double totalPrice = 0;
            switch (restaurantPackage)
            {
                case "Normal":
                    packagePrice = 500;
                    discount = 0.05;
                    totalPrice = (placePrice + packagePrice) - ((placePrice + packagePrice) * discount);
                break;
                case "Gold":
                    packagePrice = 750;
                    discount = 0.1;
                    totalPrice = (placePrice + packagePrice) - ((placePrice + packagePrice) * discount);
                    break;
                case "Platinum":
                    packagePrice = 1000;
                    discount = 0.15;
                    totalPrice = (placePrice + packagePrice) - ((placePrice + packagePrice) * discount);
                    break;
            }
            if (groupSize > 0 && groupSize <= 129)
            {
                Console.WriteLine("We can offer you the {0}", place);
                Console.WriteLine("The price per person is {0:F2}$", totalPrice / groupSize);
            }
        }
    }
}
