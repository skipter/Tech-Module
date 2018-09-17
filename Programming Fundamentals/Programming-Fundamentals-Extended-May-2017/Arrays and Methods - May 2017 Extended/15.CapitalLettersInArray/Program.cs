using System;
using System.Linq;
namespace _15.CapitalLettersInAr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] capitalArray = Console.ReadLine().Split(' ');
            int counter = 0;
            for (int cnt = 0; cnt < capitalArray.Length; cnt++)
            {
                string currentElement = capitalArray[cnt];

                if (currentElement.Length == 1)     // If you change currentElement with capitalArray, it will catch also Capital Letters in words.
                {
                    if (currentElement[0] >= 'A' && currentElement[0] <= 'Z')
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
