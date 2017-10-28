namespace _05.ClosestTwoPoints
{
    using System;
    using System.Linq;
    public class ClosestTwoPoint
    {
        public static void Main()
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);

            PrintDistance(closestPoints);
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        public static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.x, point.y);
        }

        public static void PrintDistance(Point[] closestPoints)
        {
            double distance = CalculateDistance(closestPoints[0], closestPoints[1]);
            Console.WriteLine("{0:f3}", distance);
        }

        public static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalculateDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            return closestTwoPoints;
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            int deltaX = p2.x - p1.x;
            int deltaY = p2.y - p1.y;

            double result = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return result;
        }

        public static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
        }

        public static Point ReadPoint()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point();
            point.x = numbers[0];
            point.y = numbers[1];

            return point;
        }
    }

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
