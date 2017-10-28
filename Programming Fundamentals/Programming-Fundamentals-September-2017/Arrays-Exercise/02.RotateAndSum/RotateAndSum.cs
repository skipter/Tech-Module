namespace _02.RotateAndSum
{
    using System;
    using System.Linq;
    public class RotateAndSum
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            int[] result = new int[array.Length];

            for (int i = 0; i < n; i++)
            {
                int reminder = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                    result[j] += array[j];
                }
                array[0] = reminder;
                result[0] += array[0];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
