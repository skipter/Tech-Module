using System;
using System.Collections.Generic;
using System.Linq;
namespace _3.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] phoneNames = Console.ReadLine().Split(' ').ToArray();
            string input = Console.ReadLine();
                            
            while (input != "done")
            {
               
                for (int cnt = 0; cnt < phoneNames.Length; cnt++)
                {
                    if (input == phoneNames[cnt])
                    {
                        Console.WriteLine($"{phoneNames[cnt]} -> {phoneNumbers[cnt]}");
                        break;
                    }
                }
                input = Console.ReadLine();
            }    
        }
    }
}
