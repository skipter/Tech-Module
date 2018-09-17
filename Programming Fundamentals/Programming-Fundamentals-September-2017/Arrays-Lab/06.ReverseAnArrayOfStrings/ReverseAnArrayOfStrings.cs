namespace _06.ReverseAnArrayOfStrings
{
    using System;
    using System.Linq;
    public class ReverseAnArrayOfStrings
    {
        public static void Main()
        {
            string[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Array.Reverse(array);
            foreach (var word in array)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
