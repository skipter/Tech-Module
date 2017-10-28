using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intputElements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> distinctElements = new List<int>();
            for (int index = 0; index < intputElements.Length; index++)
            {
                int currentElement = intputElements[index];
                if (!distinctElements.Contains(currentElement))
                {
                    distinctElements.Add(currentElement);
                }
            }
            Console.WriteLine(String.Join(" ", distinctElements));
        }
    }
}
