namespace _01.ConvertFromBase_10toBase_N
{
    using System;
    using System.Linq;
    using System.Numerics;
    public class Convert
    {
        public static void Main()
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger one = input[0];
            BigInteger two = input[1];

            BigInteger remainder = 0;
            string str = String.Empty;


            if (one >= 0 && one <= 10)
            {
                while (two > 0)
                {
                    remainder = two % one;
                    two /= one;
                    str = remainder.ToString() + str;
                }
                Console.WriteLine(str);
            }
            else
            {

            }
        }
    }
}
