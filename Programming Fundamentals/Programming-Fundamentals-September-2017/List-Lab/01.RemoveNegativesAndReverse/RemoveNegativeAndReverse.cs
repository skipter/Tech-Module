namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativeAndReverse
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0 )
                {
                    result.Add(list[i]);
                }
            }
            result.Reverse();
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            } 
            else
            {
                Console.WriteLine("empty");
            }
            
        }
    }
}
