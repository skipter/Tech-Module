namespace _03.Big_Power
{
    using System;
    using System.Numerics;
    public class BigPower
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 0; i < num; i++)
            {
                result *= num;
            }
            Console.WriteLine(result);
        }
    }
}
