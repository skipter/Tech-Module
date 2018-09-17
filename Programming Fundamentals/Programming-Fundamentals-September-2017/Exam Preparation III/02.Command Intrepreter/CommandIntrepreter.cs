namespace _02.Command_Intrepreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CommandIntrepreter
    {
        public static void Main()
        {                                               // 90/100 Points
            List<string> numbers = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                string input = command[0];
                switch (input)
                {
                    case "reverse":
                        Reverse(numbers, command);
                        break;
                    case "sort":
                        Sort(numbers, command);
                        break;
                    case "rollLeft":
                        RollLeft(numbers, command);
                        break;
                    case "rollRight":
                        RollRight(numbers, command);
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        public static List<string> RollRight(List<string> numbers, string[] command)
        {
            int count = int.Parse(command[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return numbers;
            }
            for (int i = 0; i < count % numbers.Count; i++)
            {
                if (i > numbers.Count)
                {
                    return numbers;
                }
                string temp = numbers.Last();
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, temp);
            }
            return numbers;
        }

        public static List<string> RollLeft(List<string> numbers, string[] command)
        {
            int count = int.Parse(command[1]);

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return numbers;
            }

            for (int i = 0; i < count; i++)
            {
                if (numbers.Count < i)
                {
                    return numbers;
                }
                string temp = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(temp);
            }
            return numbers;
            // int index = int.Parse(command[1]);
            // if (index < 0)
            // {
            //     Console.WriteLine("Invalid input parameters.");
            // }
            // index = index % numbers.Count;
            // var remove = numbers.Take(index).ToList();
            // numbers.RemoveRange(0, index);
            // numbers.AddRange(remove);
            // return numbers;
        }

        public static List<string> Sort(List<string> numbers, string[] command)
        {
            int start = int.Parse(command[2]);
            int end = int.Parse(command[4]);
            if (start < 0 || start >= numbers.Count || end < 0 || end > numbers.Count || start + end > numbers.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return numbers;
            }
            else
            {
                numbers.Sort(start, end, null);
                return numbers;
            }
        }
        public static List<string> Reverse(List<string> numbers, string[] command)
        {
            int start = int.Parse(command[2]);
            int count = int.Parse(command[4]);
            if (start < 0 || start >= numbers.Count || count < 0 || count > numbers.Count || start + count > numbers.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return numbers;
            }
            else
            {
                numbers.Reverse(start, count);
                return numbers;
            }
        }
    }
}
