namespace _04.NumbersInReversedOrder
{
    using System;
    public class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReverseNumber(number));
        }
        private static string ReverseNumber(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
