namespace _08.GreaterOfTwoValues
{
    using System;
    public class Program
    {
        static void Main()
        {
            string dataType = Console.ReadLine();
            GetDataTypeAndResult(dataType);
        }
        private static void GetDataTypeAndResult(string input)
        {
            if (input == "string")
            {
                string firstWord = Console.ReadLine();
                string secondWord = Console.ReadLine();
                Console.WriteLine(GetMax(firstWord, secondWord));
            }
            else if (input == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstNumber, secondNumber));
            }
            else if (input == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstChar, secondChar));
            }
        }
        public static int GetMax(int firstNumber, int secondNumber)
        {
            int bigger = 0;
            if (firstNumber > secondNumber)
            {
                bigger = firstNumber;
            } else
            {
                bigger = secondNumber;
            }
            return bigger;
        }
        public static string GetMax(string word, string secondWord)
        {
            string bigger = String.Empty;
            if (word.CompareTo(secondWord) >= 0)
            {
                bigger = word;
            } else
            {
                bigger = secondWord;
            }
            return bigger;
        }
        public static string GetMax(char firstChar, char secondChar)
        {
            string bigger = String.Empty;
            if (firstChar.CompareTo(secondChar) >= 0) 
            {
                bigger = firstChar.ToString();
            } else
            {
                bigger = secondChar.ToString();
            }
            return bigger;
        }
    }
}
