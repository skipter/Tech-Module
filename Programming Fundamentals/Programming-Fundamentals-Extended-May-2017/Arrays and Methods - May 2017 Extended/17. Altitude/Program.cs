using System;
using System.Collections.Generic;
using System.Linq;
namespace _17.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] altitudeArray = Console.ReadLine().Split(' ').ToArray();

            long altitude = Convert.ToInt64(altitudeArray[0]);

            for (int cnt = 0; cnt < altitudeArray.Length; cnt++)
            {
                if (altitudeArray[cnt] == "up")
                {
                    altitude += Convert.ToInt64(altitudeArray[cnt + 1]);
                }
                if (altitudeArray[cnt] == "down")
                {
                    altitude -= Convert.ToInt64(altitudeArray[cnt + 1]);
                }
                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }
            Console.WriteLine($"got through safely. current altitude: {altitude}m");
            
        }
    }
}
