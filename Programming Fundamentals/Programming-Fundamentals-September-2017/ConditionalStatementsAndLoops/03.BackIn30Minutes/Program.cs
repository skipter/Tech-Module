namespace Back_in_30_Minutes
{
    using System;
    public class Program
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            hour += minutes / 60;
            minutes = minutes % 60;

            if (hour >= 24)
            {
                hour = 0;
            }
            Console.WriteLine("{0:D1}:{1:D2}", hour, minutes);
        }
    }
}
