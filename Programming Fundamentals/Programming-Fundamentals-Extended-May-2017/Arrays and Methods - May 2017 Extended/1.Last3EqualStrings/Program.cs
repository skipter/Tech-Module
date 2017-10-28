using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Last3EqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numberList = Console.ReadLine().Split(' ').ToList();

            numberList.Reverse();
            for (int cnt = 0; cnt < numberList.Count; cnt++)
            {
                string word = numberList[cnt];
                string word2 = numberList[cnt + 1];
                string word3 = numberList[cnt + 2];
                if (word == word2 && word2 == word3)
                {
                    Console.WriteLine($"{word} {word2} {word3}");
                    break;
                }
            }            
        }
    }
}
