namespace Theatre_Promotions
{
    using System;
    public class Program
    {
        static void Main()
        {
            string typeOfTheDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            if (typeOfTheDay == "Weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    ticketPrice = 12;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 18;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (age < 0 || age > 122)
                {
                    Console.WriteLine("Error!");
                }
            } else if (typeOfTheDay == "Weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    ticketPrice = 15;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 20;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (age < 0 || age > 122)
                {
                    Console.WriteLine("Error!");
                }
            } else if (typeOfTheDay == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    ticketPrice = 5;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 12;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (age > 64 && age <= 122)
                {
                    ticketPrice = 10;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (age < 0 || age > 122)
                {
                    Console.WriteLine("Error!");
                }
            }
        } 
    }
}
