﻿namespace _07.SumArrays
{
    using System;
    using System.Linq;
    public class SumArrays
    {
        public static void Main()
        {
            int[] firstArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] resultArray = new int[Math.Max(firstArray.Length, secondArray.Length)];

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length]; 
            }
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
