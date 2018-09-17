namespace _03.EqualSums
{
    using System;
    using System.Linq;
    using System.IO;
    public class EqualSums
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("input.txt");
            File.Delete("output.txt");

            foreach (var line in input)
            {
                int[] number = line.Split(' ')
                .Select(int.Parse)
                .ToArray();

                bool isEqualSum = false;
                for (int i = 0; i < number.Length; i++)
                {
                    int[] left = number.Take(i).ToArray();
                    int[] right = number.Skip(i + 1).ToArray();
                    string output = i.ToString();
                    if (left.Sum() == right.Sum())
                    {
                        isEqualSum = true;
                        File.AppendAllText("output.txt", output);
                    }
                }
                if (!isEqualSum)
                {
                    File.AppendAllText("output", "no");
                }
            }
        }
    }
}