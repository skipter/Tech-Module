using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                int currentNumber = (int)(input[0] - '0');
                int element = int.Parse(input);
                integersList.Insert(currentNumber, element);
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", integersList));
        }   
    }
}
