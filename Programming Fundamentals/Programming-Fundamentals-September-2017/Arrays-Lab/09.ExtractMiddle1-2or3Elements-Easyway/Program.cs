namespace _09.ExtractMiddle1_2or3Elements_Easyway
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] result;
            int resultLenght = array.Length;

            if (resultLenght == 1)
            {
                result = new int[1];
                result[0] = array[0];
            } else if (resultLenght % 2 == 0)
            {
                result = new int[2];
                result[0] = array[array.Length / 2 - 1];
                result[1] = array[array.Length / 2];
            } else
            {
                result = new int[3];
                result[0] = array[array.Length / 2 - 1];
                result[1] = array[array.Length / 2];
                result[2] = array[array.Length / 2 + 1];
            }
            Console.WriteLine("{0} {1} {2}", '{', string.Join(", ", result), '}');
        }
    }
}
