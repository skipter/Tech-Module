namespace _04.Resurrection
{
    using System;
    using System.Numerics;
    public class Ressurection
    {
        public static void Main()
        {
            int amountOfPhoenix = int.Parse(Console.ReadLine());
            decimal result = 0m;
            for (int i = 0; i < amountOfPhoenix; i++)
            {
                long bodyLenght = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long lenghtOfOneWing = long.Parse(Console.ReadLine());
                result = (decimal)Math.Pow(bodyLenght, 2) * (totalWidth + 2 * lenghtOfOneWing);
                Console.WriteLine($"{result}");
            }
        }
    }
}
