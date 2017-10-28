namespace _03.SearchForANumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SearchForANumber
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '/', '[', ']', '\'', '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] modifiers = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '/', '[', ']', '\'', '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int num = modifiers[0];
            int elementsToDelete = modifiers[1];
            int numToFind = modifiers[2];

            var result = numbers.Take(num).ToList();

            result.RemoveRange(0, elementsToDelete);
            

            if (result.Contains(numToFind) == true)
            {
                Console.WriteLine("YES!");
            } 
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
