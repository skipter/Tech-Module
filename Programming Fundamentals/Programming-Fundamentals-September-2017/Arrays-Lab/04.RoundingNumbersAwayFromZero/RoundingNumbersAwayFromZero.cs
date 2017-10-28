namespace _05.RoundingNumbersAwayFromZero
{
    using System;
    using System.Linq;
    public class RoundingNumbersAwayFromZero
    {
        public static void Main()
        {
            double[] array = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {Math.Round(array[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
