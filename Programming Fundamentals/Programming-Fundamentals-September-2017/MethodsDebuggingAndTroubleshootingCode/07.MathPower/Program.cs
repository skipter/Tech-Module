namespace _07.MathPower
{
    using System;
    public class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());

            double result = RaiseNumber(number, powerNumber);
            Console.WriteLine($"{result}");
        }
        private static double RaiseNumber(double number, double power)
        {
            double resultNumber = Math.Pow(number, power);
            return resultNumber;
        }
    }
}
