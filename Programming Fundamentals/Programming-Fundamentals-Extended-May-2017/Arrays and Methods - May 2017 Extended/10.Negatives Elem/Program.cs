using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Negatives_Elem
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTokens = int.Parse(Console.ReadLine());
            int[] arrayToCheck = new int[numberOfTokens];

            int negativeCounter = 0;

            for (int cnt = 0; cnt < numberOfTokens; cnt++)
            {
                arrayToCheck[cnt] = int.Parse(Console.ReadLine());
                if (arrayToCheck[cnt] < 0)
                {
                    negativeCounter++;
                }
            }
            Console.WriteLine(negativeCounter);
        }
    }
}
