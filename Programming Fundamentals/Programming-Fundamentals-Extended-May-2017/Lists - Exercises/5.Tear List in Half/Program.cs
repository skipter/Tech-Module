using System;
using System.Collections.Generic;
using System.Linq;
namespace _5.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listForSeparation = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            TearListInHalf(listForSeparation);
        }
        private static void TearListInHalf (List<int> list)
        {
            var firstList = new List<int>();
            var secondList = new List<int>();

            for (int cnt = 0; cnt < list.Count; cnt++)
            {
                if (cnt < list.Count / 2)
                {
                    firstList.Add(list[cnt]);
                } else
                {
                    secondList.Add(list[cnt]);
                }
            }
            Output(firstList, secondList);
        }

        private static void Output(List<int> firstList, List<int> secondList)
        {
            var resultList = new List<int>();

            for (int cnt = 0; cnt < firstList.Count; cnt++)
            {
                int firstDigit = secondList[cnt] / 10;
                int secondDigit = secondList[cnt] % 10;
                resultList.Add(firstDigit);
                resultList.Add(firstList[cnt]);
                resultList.Add(secondDigit);
            }
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
