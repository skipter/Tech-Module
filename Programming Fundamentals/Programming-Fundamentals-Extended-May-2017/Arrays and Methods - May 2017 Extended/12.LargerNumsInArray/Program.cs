using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.LergerNumsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] elements = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
          //  double[] elements = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double specialNum = double.Parse(Console.ReadLine());
            int counter = 0;
            for (int cnt = 0; cnt < elements.Length; cnt++)
            {
                if (elements[cnt] > specialNum)
                {
                    counter++;
                }                
            }
            Console.WriteLine(counter);
        }
    }
}
