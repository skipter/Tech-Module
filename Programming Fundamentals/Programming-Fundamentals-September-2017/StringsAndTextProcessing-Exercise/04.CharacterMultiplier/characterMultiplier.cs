namespace _04.CharacterMultiplier
{
    using System;
    using System.Linq;
    using System.Numerics;
    public class characterMultiplier
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ').ToArray();

            string first = line[0];
            string two = line[1];

            char[] firstLine = first.ToCharArray();
            char[] secondLine = two.ToCharArray();

            int min = Math.Min(firstLine.Length, secondLine.Length);
            int sum = 0;
            int max = Math.Max(firstLine.Length, secondLine.Length);
            for (int i = 0; i < min; i++)
            {
                sum += firstLine[i] * secondLine[i];
                secondLine[i]--;

            }
            if (firstLine.Length != secondLine.Length)
            {
                string longerInput = first.Length > two.Length ? longerInput = first : longerInput = two;

                for (int i = min; i < max; i++)
                {
                    sum += longerInput[i];
                }
            }
            string output = sum.ToString();
            Console.WriteLine(output);
        }
    }
}
