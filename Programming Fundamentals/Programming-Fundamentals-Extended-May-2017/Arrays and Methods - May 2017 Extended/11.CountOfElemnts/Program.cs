using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CountOfElemnts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayTokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentToken = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int cnt = 0; cnt < arrayTokens.Length; cnt++)
            {
                if (arrayTokens[cnt] == currentToken)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
