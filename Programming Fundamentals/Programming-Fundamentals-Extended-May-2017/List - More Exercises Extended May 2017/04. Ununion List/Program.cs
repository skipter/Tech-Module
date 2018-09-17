using System;
using System.Collections.Generic;
using System.Linq;
namespace _4.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> currentList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

                for (int cnt = 0; cnt < currentList.Count; cnt++)
                {
                    int currentElement = currentList[cnt];
                    if (primalList.Contains(currentElement))
                    {
                        primalList.RemoveAll(e => e == currentElement);
                    } else
                    {
                        primalList.Add(currentElement);
                    }
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
