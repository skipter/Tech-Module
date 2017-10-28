namespace _04.SieveOfEratosthenes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SieveOfEratoshenes
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool[] boolArray = new bool[number + 1];

            for (int i = 0; i < boolArray.Length; i++)
            {
                boolArray[i] = true;
            }

            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (boolArray[i])
                {
                    for (int j = i * i; j < number + 1; j += i)
                    {
                        boolArray[j] = false;
                    }
                }
            }

            List<int> result = new List<int>();
            for (int i = 2; i < boolArray.Length; i++)
            {
                if (boolArray[i])
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
