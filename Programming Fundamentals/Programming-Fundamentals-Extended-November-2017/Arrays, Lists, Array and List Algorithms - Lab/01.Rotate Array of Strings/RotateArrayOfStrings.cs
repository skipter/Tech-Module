namespace _01.Rotate_Array_of_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            List<string> elements = Console.ReadLine().Split().ToList();
            string temp = elements.Last();
            elements.Insert(0, temp);
            elements.RemoveAt(elements.Count - 1);
            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
