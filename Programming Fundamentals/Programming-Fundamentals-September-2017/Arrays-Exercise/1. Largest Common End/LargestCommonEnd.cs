namespace _1.Largest_Common_End
{
    using System;
    using System.Linq;
    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] secondArray = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int arraysLenght = Math.Min(firstArray.Length, secondArray.Length);
            int count = 0;
            for (int i = 0; i < arraysLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                } else
                {
                    break;
                }
            }
            
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            int secondCount = 0;
            for (int i = 0; i < arraysLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    secondCount++;
                }
            }
            if (count >= secondCount)
            {
                Console.WriteLine(count);
            } else
            {
                Console.WriteLine(secondCount);
            }

        }
    }
}
