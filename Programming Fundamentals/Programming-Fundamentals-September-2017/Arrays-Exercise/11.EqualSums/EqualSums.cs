namespace _11.EqualSums
{
    using System;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            int[] number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool isEqualSum = false;
            for (int i = 0; i < number.Length; i++)
            {
                int[] left = number.Take(i).ToArray();
                int[] right = number.Skip(i + 1).ToArray();

                if (left.Sum() == right.Sum())
                {
                    isEqualSum = true;
                    Console.WriteLine(i);
                }
            }
            if (!isEqualSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
