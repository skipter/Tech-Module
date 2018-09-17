namespace _01.Charity_Marathon
{
    using System;
    public class CharityMarathon
    {                                               // 80/100 - MissingCase
        public static void Main()
        {
            try
            {
                long days = Math.Abs(long.Parse(Console.ReadLine()));
                long runners = Math.Abs(long.Parse(Console.ReadLine()));
                long laps = Math.Abs(long.Parse(Console.ReadLine()));
                long trackMeters = Math.Abs(long.Parse(Console.ReadLine()));
                long maxPeople = Math.Abs(long.Parse(Console.ReadLine()));
                decimal moneyPerKm = Math.Abs(decimal.Parse(Console.ReadLine()));

                var runnersPerDay = runners / days;

                if (runnersPerDay < maxPeople)
                {

                }
                else if (runnersPerDay > maxPeople)
                {
                    runnersPerDay = maxPeople;
                }

                var totalRunners = runnersPerDay * days;
                var totalMeters = totalRunners * laps * trackMeters;
                var km = totalMeters / 1000;

                decimal money = km * moneyPerKm;
                Console.WriteLine($"Money raised: {money:F2}");
            }
            catch
            {

                Console.WriteLine("No");
                
            }
            
        }
    }
}
