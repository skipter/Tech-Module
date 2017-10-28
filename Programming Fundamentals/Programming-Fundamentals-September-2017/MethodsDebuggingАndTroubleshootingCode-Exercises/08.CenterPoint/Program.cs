namespace _08.CenterPoint
{
    using System;
    public class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (CloserPoint(x1, y1, x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            } else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        public static double CalculateDistane(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)));
            return distance;
        }
        private static bool CloserPoint (double x1, double y1, double x2, double y2)
        {
            var firstDistance = CalculateDistane(x1, y1, 0, 0);
            var secondDistance = CalculateDistane(x2, y2, 0, 0);

            if (firstDistance > secondDistance)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
