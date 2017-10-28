namespace _11.GeometryCalculator
{
    using System;
    public class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine();

            if (figure.Equals("triangle")) {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double output = GetTriangleArea(side, height);
                Console.WriteLine($"{output:F2}");
            }
            else if (figure.Equals("square")) {
                double side = double.Parse(Console.ReadLine());
                double output = GetSquareArea(side);
                Console.WriteLine($"{output:F2}");
            }
            else if (figure.Equals("rectangle")) {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double output = GetRectangleArea(width, height);
                Console.WriteLine($"{output:F2}");
            }
            else if (figure.Equals("circle")) {
                double radius = double.Parse(Console.ReadLine());
                double output = GetCircleArea(radius);
                Console.WriteLine($"{output:F2}");
            }
        }


        static double GetTriangleArea (double side, double height)
        {
            double area = side * height / 2;
            return area;
        }

        static double GetSquareArea (double side)
        {
            double area = side * side;
            return area;
        }

        static double GetRectangleArea (double width, double height)
        {
            double area = width * height;
            return area;
        }

        static double GetCircleArea (double radius)
        {
            double area = radius * radius * Math.PI;
            return area;
        }
    }
}
