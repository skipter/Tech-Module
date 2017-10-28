namespace _03.Intersection_fCircles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class IntersectionOfCircles
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Circle c1 = new Circle()
            {
                x = list[0],
                y = list[1],
                Radius = list[2],
            };

            Circle c2 = new Circle()
            {
                x = list2[0],
                y = list2[1],
                Radius = list2[2],
            };
            if (Intersect(c1, c2))
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            var firstPoint = Math.Abs(c1.x - c2.y);
            var secondPoint = Math.Abs(c1.y - c2.y);
            var distance = Math.Sqrt(Math.Pow(firstPoint, 2) + Math.Pow(secondPoint, 2));
            var sumRadiuses = c1.Radius + c2.Radius;

            if (distance <= sumRadiuses)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public class Circle
        {
            public int Center { get; set; }
            public int Radius { get; set; }
            public int x { get; set; }
            public int y { get; set; }
        }
    }
}
