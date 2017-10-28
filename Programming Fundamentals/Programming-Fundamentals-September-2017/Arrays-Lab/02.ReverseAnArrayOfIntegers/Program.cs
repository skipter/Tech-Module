namespace _02.ReverseAnArrayOfIntegers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] numberArray = new int[num];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] += int.Parse(Console.ReadLine());
            }
            Array.Reverse(numberArray);
            Console.WriteLine(string.Join(" ", numberArray));
        }
    }
}
