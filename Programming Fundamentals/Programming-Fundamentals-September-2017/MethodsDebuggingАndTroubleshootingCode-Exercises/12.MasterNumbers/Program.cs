namespace _12.MasterNumbers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (ContainsEvenDigit(i) && SumOfDigitsDivineBySeven(i) && IsPalindrome(i)) 
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool SumOfDigitsDivineBySeven(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool ContainsEvenDigit(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

         static bool IsPalindrome(int number)
        {
            string text = number.ToString();

            for (int i = 0; i <= text.Length / 2; i++)
            {
                if (text[i] == text[text.Length - 1 - i])
                {

                } else
                {
                    return false;
                }
            }   
            return true;
        }
    }
}

