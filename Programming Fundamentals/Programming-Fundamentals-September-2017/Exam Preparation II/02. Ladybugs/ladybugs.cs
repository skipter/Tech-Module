namespace _02.Ladybugs
{
    using System;
    using System.Linq;
    public class Ladybugs
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] bugsIndices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var bug in bugsIndices)
            {
                if (bug < 0 || bug >= field.Length)
                {
                    continue;
                }
                field[bug] = 1;
            }

            while (true)
            {
                string commands = Console.ReadLine();
                if (commands == "end")
                {
                    break;
                }
                string[] tokens = commands.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int bugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLenght = int.Parse(tokens[2]);

                if (bugIndex < 0 || bugIndex >= fieldSize)
                {
                    continue;
                }
                if (field[bugIndex] == 0)
                {
                    continue;
                }
                field[bugIndex] = 0;
                int position = bugIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        position += flyLenght;
                    }
                    else
                    {
                        position -= flyLenght;
                    }
                    if (position < 0 || position >= fieldSize)
                    {
                        break;
                    }
                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
