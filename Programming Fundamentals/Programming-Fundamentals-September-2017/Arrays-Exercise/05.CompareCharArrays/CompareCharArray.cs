namespace _05.CompareCharArrays
{
    using System;
    using System.Linq;
    public class CompareCharArray
    {
        public static void Main()
        {
            char[] firstArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] secondArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            int lenght = Math.Min(firstArray.Length, secondArray.Length);

            bool isFirst = false;

            for (int i = 0; i < lenght; i++)
            {
                var index1 = (int)firstArray[i];
                var index2 = (int)secondArray[i];
                
                if (index1 <= index2)
                    {
                        isFirst = true;
                    }
                    else
                    {
                        break;
                    }
            }
            if (isFirst == true && lenght == firstArray.Length)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
        }
    }
}
