using System;
using System.Linq;
namespace _13.IncrsingElmInArray
{
    class Program
    {        
        static void Main(string[] args)
        {
           int[] arrayElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool IsIncreasing = false;
            for (int cnt = 0; cnt < arrayElements.Length - 1; cnt++)
            {
                if (IsIncreasing = arrayElements[cnt] < arrayElements[cnt + 1]) 
                {
                    IsIncreasing = true;
                } else
                {
                    IsIncreasing = false;
                    break;
                }                
            }
            if (IsIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }        
    }
}
