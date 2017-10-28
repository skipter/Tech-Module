namespace _10.CenturiesToNanoseconds
{
    using System;
    public class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            decimal hours = days * 24M;
            decimal minutes = hours * 60M;
            decimal seconds = minutes * 60M;
            decimal miliSeconds = seconds * 1000;
            decimal microSeconds = miliSeconds * 1000;
            decimal nanoSeconds = microSeconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = " +
                $"{minutes} minutes = {seconds} seconds = " +
                $"{miliSeconds} milliseconds = {microSeconds} microseconds = " +
                $"{nanoSeconds} nanoseconds");
        }
    }
}
