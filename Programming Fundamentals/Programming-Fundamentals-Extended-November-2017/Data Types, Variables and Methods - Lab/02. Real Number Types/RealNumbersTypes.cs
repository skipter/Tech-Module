namespace _02.Real_Number_Types
{
    using System;
    public class RealNumbersTypes
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(number, num));
        }
    }
}
