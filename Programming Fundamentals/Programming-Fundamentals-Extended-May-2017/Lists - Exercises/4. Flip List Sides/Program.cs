using System;
using System.Collections.Generic;
using System.Linq;
namespace _4.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            ReverseList(list);

        }
        private static void ReverseList(List<int> list)
        {
            var newList = new List<int>();
            var lastNum = list.Count - 1;

            newList.Add(list[0]);

            for (int i = list.Count - 2; i >= 1; i--)
            {
                newList.Add(list[i]);
            }
            newList.Add(list[lastNum]);
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
