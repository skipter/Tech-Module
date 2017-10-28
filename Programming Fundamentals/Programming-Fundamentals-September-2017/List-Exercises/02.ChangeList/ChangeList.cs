namespace _02.ChangeList
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ChangeList
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '/', '[', ']', '\'', '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Odd" || input != "Even")
            {
                var inputList = input
                    .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '/', '[', ']', '\'', '\\' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                int index = 0;
                int number;

                if (inputList[0] == "Delete")
                {
                    number = int.Parse(inputList[1]);
                    for (int i = 0; i < numbers.Count ; i++)
                    {
                        if (numbers[i] == number)
                        {
                            numbers.Remove(number);
                            i--;
                        }
                    }
                }

                if (inputList[0] == "Insert")
                {
                    index = int.Parse(inputList[1]);
                    number = int.Parse(inputList[2]);
                    numbers.Insert(number, index);
                }

                if (inputList[0] == "Odd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else if (inputList[0] == "Even")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
