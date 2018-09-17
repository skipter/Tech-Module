namespace _06.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FoldandSum
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List <int> takenParts = new List<int>();
            List<int> result = new List<int>();
            int elementsToTake = numbers.Count / 4;
            takenParts.AddRange(numbers.Take(elementsToTake).Reverse());
            numbers.RemoveRange(0, elementsToTake);
            numbers.Reverse();
            takenParts.AddRange(numbers.Take(elementsToTake));
            numbers.RemoveRange(0, elementsToTake);
            numbers.Reverse();

            for (int i = 0; i < takenParts.Count; i++)
            {
                int currentResult = numbers[i] + takenParts[i];
                result.Add(currentResult);
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
