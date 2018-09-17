namespace _05.MagicExchangeableWords
{
    using System;
    using System.Linq;
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var lines = Console.ReadLine().Split(' ').ToList();

            string first = lines[0];
            string second = lines[1];
            char[] frst = first.ToCharArray();
            char[] scnd = second.ToCharArray();
            var newFirst = frst.Distinct().ToList();
            var newSecond = scnd.Distinct().ToList();
            bool areEquals = newFirst.Count == newSecond.Count;
            if (areEquals)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
