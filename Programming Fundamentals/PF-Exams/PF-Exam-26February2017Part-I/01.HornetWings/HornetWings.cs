namespace _01.HornetWings
{
    using System;
    public class HornetWings
    {
        static void Main()
        {                                               // 100/100 Points
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePer1000flaps = double.Parse(Console.ReadLine()); // for/per 1000 wing flaps
            int endurance = int.Parse(Console.ReadLine());

            //You can assume that a hornet makes 100 wing flaps per second.

            double traveledDistance = distancePer1000flaps * (wingFlaps / 1000); //Distance
            int timeHornetFlaps = wingFlaps / 100; // seconds that hornet is flap "wingFlap" times
            int timesToRest = wingFlaps / endurance;
            int allTimeToRest = timesToRest * 5;
            int totalTimeInSeconds = allTimeToRest + timeHornetFlaps;

            Console.WriteLine($"{traveledDistance:F2} m.");
            Console.WriteLine($"{totalTimeInSeconds} s.");
        }
    }
}
