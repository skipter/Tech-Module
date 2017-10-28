using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.LargeElemnInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTokens = int.Parse(Console.ReadLine());
            int[] arrayOfIntegers = new int[numberOfTokens];
            int biggest = Int32.MinValue;
            for (int cnt = 0; cnt < numberOfTokens; cnt++)
            {
                arrayOfIntegers[cnt] = int.Parse(Console.ReadLine());
               if (arrayOfIntegers[cnt] > biggest)
                {
                    biggest = arrayOfIntegers[cnt];
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
