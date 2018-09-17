using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.RemoveNegativeRever
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> removeNegatives = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool IsEmpty = false;
            for (int cnt = 0; cnt < removeNegatives.Count; cnt++)
            {
                if (removeNegatives[cnt] < 0)
                {
                    removeNegatives.RemoveAt(cnt);
                    cnt--;
                }
            }
            removeNegatives.Reverse();
            if (removeNegatives.Count > 0)
            {
                Console.WriteLine(String.Join(" ", removeNegatives));
            } else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
