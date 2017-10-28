namespace _08.CondenseArrayToNumber
{
    using System;
    using System.Linq;
    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] condensed = new int[array.Length - 1];

            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
            }

            if (array.Length != 1)
            { 
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < condensed.Length - i; j++)
                    {
                        condensed[j] = array[j] + array[j + 1];
                    }
                    array = condensed;
                }
                Console.WriteLine(condensed[0]);
            }
                
        }
    }
}
