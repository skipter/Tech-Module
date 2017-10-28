namespace _01.ReverseString
{
    using System;
    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] reverse = input.ToCharArray();
            Array.Reverse(reverse);
            Console.WriteLine(reverse);
        }
    }
}
