namespace _07.ExchangeVariableValues
{
    using System;
    public class Program
    {
        static void Main()
        {
            int firstInteger = 5;
            int secondInteger = 10;
            int a = firstInteger;
            int b = secondInteger;
            int c = a;
            int d = b;
            a = b; b = c;
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstInteger}");
            Console.WriteLine($"b = {secondInteger}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
