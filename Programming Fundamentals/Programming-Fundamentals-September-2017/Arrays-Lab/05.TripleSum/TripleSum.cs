using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TripleSum
{
    public class TripleSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isSumAvaible = false;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    int sum = numbers[a] + numbers[b]
;                        if (numbers.Contains(sum))
                        {
                                isSumAvaible = true;
                                Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sum}");
                        } 
                }
            }
            if (!isSumAvaible)
            {
                Console.WriteLine("No");
            }
        }
    }
}
