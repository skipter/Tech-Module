namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Linq;
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            double output = CalculateDistance(p1, p2);
            Console.WriteLine($"{output:F3}");
        }

        public static Point ReadPoint()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point();
            point.x = numbers[0];
            point.y = numbers[1];

            return point;
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            int deltaX = p2.x - p1.x;
            int deltaY = p2.y - p1.y;

            double result = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return result;
        }
    }

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
