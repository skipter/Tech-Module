namespace _05.TemperatureConversion
{
    using System;
    public class Program
    {
        static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            ConvertFahrenheitInCelsius(fahrenheit);
        }
        
        public static void ConvertFahrenheitInCelsius(double number)
        {
            double conversion = (number - 32) * 5 / 9;
            Console.WriteLine($"{conversion:F2}");
        }
    }
}
