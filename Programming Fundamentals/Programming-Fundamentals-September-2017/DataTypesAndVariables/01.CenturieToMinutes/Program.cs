namespace _01.CenturieToMinutes
{
    using System;
    public class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(years * 365.2422);        // 365.2422
            int hours = 24 * days;
            int minutes = 60 * hours;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes ");
        }
    }
}
