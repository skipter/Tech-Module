namespace _02.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();

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
                    }
                    else
                    {
                        phonebook[name] = telephone;
                    }
                }
                else if (command == "S")
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
                } else if (command == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
