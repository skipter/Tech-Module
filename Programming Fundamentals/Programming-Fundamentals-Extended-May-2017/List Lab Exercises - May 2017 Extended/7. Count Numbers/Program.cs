using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Add(0);
            var counter = 1;
            for (int cnt = 0; cnt < numbers.Count - 1; cnt++)
            {
                if (numbers[cnt] == numbers[cnt +1])
                {
                    counter++;
                } else
                {
                    Console.WriteLine($"{numbers[cnt]} -> {counter}");
                    counter = 1;
                }
            }
        }
    }
}
