namespace _03.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            List<decimal> result = new List<decimal>();

            int index = 0;
            decimal sum = 0;
            bool isSum = true;          


            while (isSum)
            {

                isSum = false;

                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        index = i - 1;                          //Index of element to be removed.
                        sum = numbers[i] + numbers[i - 1];
                        isSum = true;
                        break;
                    }
                }
                //If there is sum, else it will remove elements and broke the code.
                if (isSum)
                {
                    numbers.RemoveRange(index, 2);              //Use index element.
                    numbers.Insert(index, sum);                 //Insert sum after remove element
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
