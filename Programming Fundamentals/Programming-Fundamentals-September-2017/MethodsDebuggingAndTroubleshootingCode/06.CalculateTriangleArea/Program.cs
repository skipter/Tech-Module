namespace _06.CalculateTriangleArea
{
    using System;
    public class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = TriangleArea(width, height);
            Console.WriteLine(area);
        }

        private static double TriangleArea(double width, double height)
        {
            double area = width * height / 2;
                return area;
        }
    }
}
