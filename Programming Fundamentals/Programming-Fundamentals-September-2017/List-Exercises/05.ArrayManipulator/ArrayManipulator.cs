namespace _05.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ArrayManipulator
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '/', '[', ']', '\'', '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "print")
            {
                var commandLine = input
               .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '/', '[', ']', '\'', '\\' }, StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

                int index;
                int num;

                if (commandLine[0] == "add")
                {
                    index = int.Parse(commandLine[1]);
                    num = int.Parse(commandLine[2]);
                    numbers.Insert(index, num);
                }
                else if (commandLine[0] == "addMany")
                {
                    index = int.Parse(commandLine[1]);
                    numbers.InsertRange(index, commandLine.Skip(2).Select(int.Parse).ToList());
                }
                else if (commandLine[0] == "contains")
                {
                    num = int.Parse(commandLine[1]);
                    Console.WriteLine(numbers.IndexOf(num));
                }
                else if (commandLine[0] == "remove")
                {
                    index = int.Parse(commandLine[1]);
                    numbers.RemoveAt(index);
                }
                if (commandLine[0] == "shift")
                {
                    index = int.Parse(commandLine[1]);
                    index = index % numbers.Count;
                    var remove = numbers.Take(index).ToList();
                    numbers.RemoveRange(0, index);
                    numbers.AddRange(remove);
                }
                else if (commandLine[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                } 
               
                input = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
    }
}
