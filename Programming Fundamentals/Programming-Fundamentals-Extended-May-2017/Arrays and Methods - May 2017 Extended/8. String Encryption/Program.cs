namespace _08.String_Encryption
{
    using System;    
    public class StringEncryption
    {
        public static void Main()
        {
            int numberOfChars = int.Parse(Console.ReadLine());
            var output = string.Empty;
            for (int i = 0; i < numberOfChars; i++)
            {
                char characters = char.Parse(Console.ReadLine());
                var encryptChar = EncriptChar(characters, numberOfChars);
                output += encryptChar;
            }
            Console.WriteLine(output);
        }
        static string EncriptChar(char characters, int n)
        {
            var result = string.Empty;
            var charInNumbers = (int)characters;
            var firstDigit = 0;
            var lastDigit = charInNumbers % 10;
            var firstEncryptedChar = (char)(characters + lastDigit);
            var counter = 0;

            if (charInNumbers > 9 && charInNumbers < 100)
            {
                counter = 2;
            }
            else
            {
                counter = 3;
            }

            while (counter > 1)
            {
                charInNumbers /= 10;
                firstDigit = charInNumbers;
                counter--;
            }
            var lastEncryptedChar = (char)(characters - firstDigit);
            result = $"{firstEncryptedChar}{firstDigit}{lastDigit}{lastEncryptedChar}";
            return result;
        }
    }
}