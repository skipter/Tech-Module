using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Stuck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            //  var minNumberInList = FindMinDigits(firstList, secondList);
            var result = ListUnited(firstList, secondList);
            Console.WriteLine(string.Join(" ", result));
        }
        private static List<int> ListUnited (List<int> list1, List<int> list2)
        {
            var firstListResult = new List<int>();
            var secondListResult = new List<int>();
            var resultList = new List<int>();
            
           foreach (var number in list1) // adding smallest nums in new list
            {
                    var stringNumber = Math.Abs(number).ToString();

                    if (stringNumber.Length == FindMinDigits(list1, list2))
                    {
                        firstListResult.Add(number);
                    }
                }
            foreach (var number in list2) // adding smallest nums in new list
            {
                var stringNumber = Math.Abs(number).ToString();

                if (stringNumber.Length == FindMinDigits(list1, list2))
                {
                    secondListResult.Add(number);
                }
            }
            var totalLength = firstListResult.Count + secondListResult.Count;
            for (int cnt = 0; cnt < totalLength; cnt++)
            {
                var firstListNumber = 0;
                var secondListNumber = 0;

                if (secondListResult.Count > cnt)
                {
                    secondListNumber = secondListResult[cnt];
                    resultList.Add(secondListNumber);
                }
                if (firstListResult.Count > cnt)
                {
                    firstListNumber = firstListResult[cnt];
                    resultList.Add(firstListNumber);
                }
            }
            return resultList;
        }
        
        private static int FindMinDigits (List<int> list1, List<int> list2)
        {
            var maxDigits = int.MaxValue;
            foreach (var number in list1)
            {
                var stringLength = Math.Abs(number).ToString(); //Search for biggest digits in list1
                if (stringLength.Length < maxDigits)
                {
                    maxDigits = stringLength.Length;
                }
            }
            foreach (var number in list2)
            {
                var stringLength = Math.Abs(number).ToString();  //Search for biggest digits in list2
                if (stringLength.Length < maxDigits)
                {
                    maxDigits = stringLength.Length;
                }
            }
            return maxDigits;
         }
     }
}
