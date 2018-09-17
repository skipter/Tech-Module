namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                var commandArguments = input.Split(' ').ToList();

                string command = commandArguments[0];
                
                if (command == "A")
                {
                    string name = commandArguments[1];
                    string telephone = commandArguments[2];

                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, telephone);
                    } else
                    {
                        phonebook[name] = telephone;
                    }
                }
                else
                {
                    string name = commandArguments[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                   else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
