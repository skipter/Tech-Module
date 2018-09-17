namespace _18.DifferentIntegersSize
{
    using System;
    public class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            try
            {
                long numberToCheck = long.Parse(number);

                if (numberToCheck >= long.MinValue && numberToCheck <= long.MaxValue)
                {
                    Console.WriteLine($"{numberToCheck} can fit in:");

                    if (numberToCheck >= sbyte.MinValue && numberToCheck <= sbyte.MaxValue)
                    {
                        Console.WriteLine($"* sbyte");
                    }
                    if (numberToCheck >= byte.MinValue && numberToCheck <= byte.MaxValue)
                    {
                        Console.WriteLine($"* byte");
                    }
                    if (numberToCheck >= short.MinValue && numberToCheck <= short.MaxValue)
                    {
                        Console.WriteLine($"* short");
                    }
                    if (numberToCheck >= ushort.MinValue && numberToCheck <= ushort.MaxValue)
                    {
                        Console.WriteLine($"* ushort");
                    }
                    if (numberToCheck >= int.MinValue && numberToCheck <= int.MaxValue)
                    {
                        Console.WriteLine($"* int");
                    }
                    if (numberToCheck >= uint.MinValue && numberToCheck <= uint.MaxValue)
                    {
                        Console.WriteLine($"* uint");
                    }
                    if (numberToCheck >= long.MinValue && numberToCheck <= long.MaxValue)
                    {
                        Console.WriteLine($"* long");
                    }
                } 
            }
            catch
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
