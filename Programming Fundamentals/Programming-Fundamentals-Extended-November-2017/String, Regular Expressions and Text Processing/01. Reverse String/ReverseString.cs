namespace _01.Reverse_String
{
    using System;
    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string result = String.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            Console.WriteLine(result);
        }
    }
}
