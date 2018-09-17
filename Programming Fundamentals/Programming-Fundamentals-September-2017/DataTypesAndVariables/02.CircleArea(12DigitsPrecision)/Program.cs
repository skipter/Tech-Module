namespace _02.CircleArea_12DigitsPrecision_
{
    using System;
    public class Program
    {
        static void Main()
        {
            double radiusCircle = double.Parse(Console.ReadLine());
            double areaCircle = radiusCircle * radiusCircle * Math.PI;
            Console.WriteLine($"{areaCircle:F12}");
        }
    }
}
