using System;
using System.Collections.Generic;
using System.Linq;
namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();            
            List<int> secondResult = new List<int>();
            
            for (int cnt = 0; cnt < firstList.Count; cnt++)
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    if (firstList[cnt] == secondList[i])
                    {
                       secondList.RemoveAt(i);
                        i--;
                    }
                }
            }
            long sumList1 = 0L;
            long sumList2 = secondList.Sum();

            foreach (int num in firstList)
            {
                sumList1 += num;
            }
            if (sumList1 == sumList2)
            {
                Console.WriteLine("Yes. Sum: " + sumList2);
            } else
            {
                Console.WriteLine("No. Diff: " + Math.Abs(sumList2 - sumList1));
            }
        }
    }
}
