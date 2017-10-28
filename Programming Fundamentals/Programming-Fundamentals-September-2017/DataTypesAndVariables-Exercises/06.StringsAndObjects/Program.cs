namespace _06.StringsAndObjects
{
    using System;
    public class Program
    {
        static void Main()
        {
            string firstString = "Hello";
            string secondString = "World";
            object concatenation = firstString + " " + secondString;
           // string thirdString = (string)concatenation;
            Console.WriteLine(concatenation);
        }
    }
}
