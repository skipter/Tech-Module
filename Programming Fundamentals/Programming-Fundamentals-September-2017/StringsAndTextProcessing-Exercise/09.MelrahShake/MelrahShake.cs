namespace _09.MelrahShake
{
    using System;
    public class MelrahShake
    {
        public static void Main()
        {
            string firstLine = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                int firstIndex = firstLine.IndexOf(pattern);
                int lastIndex = firstLine.LastIndexOf(pattern);

                if (firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex)
                {
                    firstLine = firstLine.Remove(lastIndex, pattern.Length);
                    firstLine = firstLine.Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }
                pattern = pattern.Remove(pattern.Length / 2, 1);
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(firstLine);
        }
    }
}
