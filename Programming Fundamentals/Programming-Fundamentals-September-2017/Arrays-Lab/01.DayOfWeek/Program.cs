using System;
namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] daysOfWeek = new string[7] 
            {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(daysOfWeek[day - 1]);
                
            } else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
