namespace _01.ConvertFromBase_10toBase_N
{
    using System;
    using System.Linq;
    using System.Numerics;
    public class Convert
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int one = int.Parse(input[0]);
            char[] two = input[1].ToCharArray();

            BigInteger result = 0;

            for (int i = two.Length - 1, n = 0; i >= 0; i--, n++)
            {
                BigInteger num = new BigInteger(char.GetNumericValue(two[n]));
                BigInteger sum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(one), i));
                result += sum;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
