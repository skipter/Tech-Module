namespace _03.FoldAndSum
{
    using System;
    using System.Linq;
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lenght = array.Length / 4;

            int[] middle = array.Skip(lenght).Take(lenght * 2).ToArray();
            int[] left = array.Take(lenght).ToArray();
            int[] right = array.Skip(lenght + (lenght * 2)).Take(lenght).ToArray();
            Array.Reverse(left);
            Array.Reverse(right);

            int[] result = new int[lenght * 2];

            for (int i = 0; i < lenght; i++)
            {
                result[i] = middle[i] + left[i];
                result[i + lenght] = middle[i + lenght] + right[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
