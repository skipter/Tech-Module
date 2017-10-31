namespace _01.SoftUni_Coffee_Orders
{
    using System;
    using System.Globalization;
    public class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            DateTime date = new DateTime();
            decimal total = 0;
            for (int i = 0; i < n; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());
                int month = date.Month;
                int year = date.Year;
                int days = DateTime.DaysInMonth(year, month);
                decimal sum = (decimal)((days * capsules) * price);
                Console.WriteLine($"The price for the coffee is: ${sum:F2}");
                total += sum;
            }
            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
