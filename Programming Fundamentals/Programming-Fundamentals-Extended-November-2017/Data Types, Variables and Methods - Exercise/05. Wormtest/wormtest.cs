namespace _05.Wormtest
{
    using System;
    using System.Numerics;
    public class Wormtest
    {
        public static void Main()
        {
            int wormLength = int.Parse(Console.ReadLine());
            double wormWidth = double.Parse(Console.ReadLine());
            long lengthInSantimeters = wormLength * 100;
            double remainder = lengthInSantimeters % wormWidth;
            double totalsum = lengthInSantimeters * wormWidth;
            double percents = (lengthInSantimeters / wormWidth) * 100;
            if (remainder == 0 || wormWidth == 0)
            {
                Console.WriteLine($"{totalsum:F2}");
            }
            else
            {
                Console.WriteLine($"{percents:F2}%");
            }
        }
    }
}
