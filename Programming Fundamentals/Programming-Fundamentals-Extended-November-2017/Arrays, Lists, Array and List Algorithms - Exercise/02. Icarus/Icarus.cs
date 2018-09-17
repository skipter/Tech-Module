namespace _02.Icarus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Icarus
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int startIndex = int.Parse(Console.ReadLine());
            int icarusDamage = 1;
            string command = Console.ReadLine();

            while (command != "Supernova")
            {
                var commandArgs = command.Split();
                string wayToMove = commandArgs[0];
                int moves = int.Parse(commandArgs[1]);

                if (wayToMove == "left")
                {

                }

                if (wayToMove == "right")
                {

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
