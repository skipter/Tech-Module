namespace _01.Hello_Name_
{
    using System;
    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            GreetingMethod(input);
        }
        static void GreetingMethod(string input)
        {
            Console.WriteLine("Hello, {0}!", input);
        }
    }
}
