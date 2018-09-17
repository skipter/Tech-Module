using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                int firstDigit = input[0] - '0';
                elements.Insert(firstDigit, int.Parse(input));
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
