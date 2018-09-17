namespace _11.ConvertSpeedUnits
{
    using System;
    public class Program
    {
        static void Main()
        {
            float distanceInMeters = Convert.ToSingle(Console.ReadLine());
            float hours = Convert.ToSingle(Console.ReadLine());
            float minutes= Convert.ToSingle(Console.ReadLine());
            float seconds = Convert.ToSingle(Console.ReadLine());

            float timeInSeconds = (hours * 3600) + (minutes * 60) + seconds;
            float metersPerSecond = distanceInMeters / timeInSeconds;
            float kilometersPerSecond = (distanceInMeters / 1000.0f) / (timeInSeconds / 3600.0f);
            float milesPerSecond = kilometersPerSecond / 1.609f;

            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kilometersPerSecond}");
            Console.WriteLine($"{milesPerSecond}");
        }
    }
}
