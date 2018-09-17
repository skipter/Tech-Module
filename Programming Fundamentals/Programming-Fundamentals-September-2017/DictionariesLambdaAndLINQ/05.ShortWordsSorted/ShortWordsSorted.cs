namespace _05.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ShortWordsSorted
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '/', '[', ']', '\'', '\\' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            text.Sort();
            Console.WriteLine(string.Join(", ", text.Distinct().Where(x => x.Length < 5)));
        }
    }
}
