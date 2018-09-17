namespace _09.ExtractMiddle1_2or3Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ExtractMiddle
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            PrintExtractionResult(array);
        }

        public static void PrintExtractionResult (int[] array)
        {
            if (array.Length == 1)
            {
                SingleElementCase(array);
                Console.WriteLine("{0} {1} {2}", '{', array[0], '}');

            }
            else if (array.Length > 1 && array.Length % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2}", '{', string.Join(", ", EvenElementsInArray(array)), '}');
            }
            else if (array.Length > 1 && array.Length % 2 == 1)
            {
                Console.WriteLine("{0} {1} {2}", '{', string.Join(", ", OddElementsInArray(array)), '}');
            }
        }

        public static int SingleElementCase(int[] array)
        {
            return array[0];
        }

        public static List<int> OddElementsInArray (int[] array)
        {
            List<int> results = new List<int>();

            results.Add(array[array.Length / 2 - 1]);
            results.Add(array[array.Length / 2]);
            results.Add(array[array.Length / 2 + 1]);
            
            return results;
        }

        public static List<int> EvenElementsInArray (int[] array)
        {
            List<int> results = new List<int>();

            results.Add(array[array.Length / 2 - 1]);
            results.Add(array[array.Length / 2]);

            return results;
        }
    }
}
