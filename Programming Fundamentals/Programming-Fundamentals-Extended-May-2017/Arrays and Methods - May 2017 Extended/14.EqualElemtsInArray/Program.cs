using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.EqualElemtsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool IsEqual = false;
            for (int cnt = 0; cnt < arrayElements.Length - 1; cnt++)
            {
                if (arrayElements[cnt] == arrayElements[cnt + 1])
                {
                    IsEqual = true;
                } else
                {
                    IsEqual = false;
                    break;
                }
            }
            if (IsEqual)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
        }
    }
}
