namespace _06.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SumReversNumbers
    {
        public static void Main()
        {
            
            List<string> numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '/', '[', ']', '\'', '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> result = new List<int>();

            foreach (string number in numbers)
            {
                int currentNumber = ReversNumber(number);
                result.Add(currentNumber);
            }
            Console.WriteLine(result.Sum());
        }

        private static int ReversNumber(string number)
        {
            char[] array = number.ToCharArray();
            string reverse = String.Empty;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse += array[i];
            }
            return int.Parse(reverse);
        }
    }
}
