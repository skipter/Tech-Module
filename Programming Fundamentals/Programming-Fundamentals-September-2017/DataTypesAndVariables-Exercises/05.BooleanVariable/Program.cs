namespace _05.BooleanVariable
{
    using System;
    public class Program
    {
        static void Main()
        {
            string inputCommand = Console.ReadLine();
            bool isItConvert = inputCommand == "True";
            if (isItConvert)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
        }
    }
}
