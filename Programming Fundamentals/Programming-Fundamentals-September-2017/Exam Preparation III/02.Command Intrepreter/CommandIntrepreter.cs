namespace _02.Command_Intrepreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CommandIntrepreter
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();
            var reverse = new List<string>();
            var sort = new List<string>();

            while (input != "end")
            {
                var comm = input
                    .Split(new char[] { ' ', }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                int start;
                int end;

                if (input.Contains("reverse"))
                {
                    start = int.Parse(comm[2]);
                    end = int.Parse(comm[4]);
                    if (start < end)
                    {
                        reverse = numbers.Skip(start).Reverse().Skip(end).ToList();
                        numbers.RemoveRange(start, end);
                        numbers.InsertRange(start, reverse);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (input.Contains("sort"))
                {
                    start = int.Parse(comm[2]);
                    end = int.Parse(comm[4]);
                   if (start < 0 || end < 0)
                   {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        sort = numbers.Skip(start).Reverse().Skip(end).OrderBy(x => x).ToList();
                        numbers.RemoveRange(start, end);
                        numbers.InsertRange(start, sort);
                    }

                }
                else if (input.Contains("rollLeft"))
                {
                    int index;
                    var n = int.TryParse(comm[1], out index);
                    index = index % numbers.Count;
                    var remove = numbers.Take(index).ToList();
                    numbers.RemoveRange(0, index);
                    numbers.AddRange(remove);
                }
                else if (input.Contains("rollRight"))
                {

                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }
    }
}
