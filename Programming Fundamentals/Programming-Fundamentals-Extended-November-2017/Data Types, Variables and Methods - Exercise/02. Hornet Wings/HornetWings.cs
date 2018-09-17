namespace _02.Hornet_Wings
{
    using System;
    public class HornetWings
    {
        public static void Main()
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine()); //A hornet travels for 1000 wing flaps.
            long endurance = long.Parse(Console.ReadLine());            //A hornet rests for 5 seconds.
            //A hornet makes a 100 wingflaps per second.
            double distance = (wingFlaps / 1000) * distanceInMeters;
            long timeInSeconds = wingFlaps / 100;
            long totalRest = (wingFlaps / endurance) * 5;
            long totalTimeInSeconds = timeInSeconds + totalRest;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{totalTimeInSeconds} s.");
        }
    }
}
