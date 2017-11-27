namespace _03.Array_Contains_Element
{
    using System;
    using System.Linq;
    public class ArrayContainsElement
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int containedNumber = int.Parse(Console.ReadLine());
            if (numbers.Contains(containedNumber))
            {
                Console.WriteLine("yes");
            } 
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
