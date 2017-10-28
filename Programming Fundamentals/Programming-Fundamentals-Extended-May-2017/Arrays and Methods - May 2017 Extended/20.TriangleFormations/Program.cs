using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.TriangleFormations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            bool triangleValidityCondition1 = a + b > c;
            bool triangleValidityCondition2 = b + c > a;
            bool triangleValidityCondition3 = a + c > b;
            bool isValidTriangle = triangleValidityCondition1 || triangleValidityCondition2 || triangleValidityCondition3;

            if (isValidTriangle)
            {
                    Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }
            if ((a * a + b * b == c * c))
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if (b * b + c * c == a * a)
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (a * a + c * c == b * b)
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Triangle has no right angles");
            }
        }
    }
}

