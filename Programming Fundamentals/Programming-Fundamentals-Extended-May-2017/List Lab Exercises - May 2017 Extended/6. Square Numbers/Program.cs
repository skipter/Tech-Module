using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(a => a).ToList();
            foreach (var num in numbers)
            {
               if (Math.Sqrt(num) == Math.Floor(Math.Sqrt(num)))
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
