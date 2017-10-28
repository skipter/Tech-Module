namespace _10.CubeProperties
{
    using System;
    public class Program
    {
        static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double ouput = GetMethod(cubeSide, parameter);
            Console.WriteLine($"{ouput:F2}");
        }
        private static double GetMethod(double side, string parameter)
        {
            double result = 0;
            if (parameter == "face")
            {
                result = Math.Sqrt(Math.Pow(side, 2) * 2);
            }
            else if (parameter == "space")
            {
                result = Math.Sqrt(Math.Pow(side, 2) * 3);
            }
            else if (parameter == "volume")
            {
                result = Math.Pow(side, 3);
            }
            else if (parameter == "area")
            {
                result = Math.Pow(side, 2) * 6;
            }
            return result;
        }
    }
}
