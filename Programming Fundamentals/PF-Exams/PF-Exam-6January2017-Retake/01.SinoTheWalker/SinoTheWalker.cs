namespace _01.SinoTheWalker
{
    using System;
    using System.Globalization;
    public class SinoTheWalker
    {
        static void Main()
        {
            
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime shinoLeaveTheBuilding = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", provider);
            double steps = double.Parse(Console.ReadLine());
            double secondsForStep = double.Parse(Console.ReadLine());
            // 86400 seconds in 1 day
            steps = steps % 86400;
            secondsForStep = secondsForStep % 86400;

            double howLongIsHeWalk = steps * secondsForStep;
            DateTime dtm = shinoLeaveTheBuilding.AddSeconds(howLongIsHeWalk);
            string answer = string.Format("Time Arrival: {0}", dtm.ToString("HH:mm:ss"));
            Console.WriteLine(answer);
        }
    }
}
