using System;
namespace p._6_DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());

            for (int firstChar = 1; firstChar <= 4; firstChar++)
            {
                for (int secondChar = 1; secondChar  <= 4; secondChar++)
                {
                    for (int thirdChar = 1; thirdChar <= 4; thirdChar++)
                    {
                        string result = $"{firstChar}{secondChar}{thirdChar}";
                        result = result.Replace("1", "A").Replace("2", "C").Replace("3", "G").Replace("4", "T");

                        if (firstChar + secondChar + thirdChar >= matchSum)
                        {
                            Console.Write($"O{result}O ");
                        } else
                        {
                            Console.Write($"X{result}X ");
                        }
                        if (thirdChar % 4 == 0)
                        {
                            Console.WriteLine();
                        }

                    }
                }
            }
        }  
    }
}
