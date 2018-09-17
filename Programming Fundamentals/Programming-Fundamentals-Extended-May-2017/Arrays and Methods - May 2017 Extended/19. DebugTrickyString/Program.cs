using System;
namespace _19.DebugTrickyString
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            string currentString = string.Empty;
            string result = string.Empty;

            for (int i = 1; i <= numberOfStrings; i++)
            {
                currentString = Console.ReadLine();
                result += currentString + delimiter;
            }
            int remove = delimiter.Length;
            Console.WriteLine(result.Remove(result.Length - remove, remove));
        }    
    }
}
