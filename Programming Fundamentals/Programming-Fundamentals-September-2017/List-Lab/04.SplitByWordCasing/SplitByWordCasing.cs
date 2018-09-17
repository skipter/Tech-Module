namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            List<string> text = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '/', '[', ']', '\'', '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            int lower = 0; 
            int upper = 0;

            foreach (var word in text)
            {

                foreach (var letters in word)
                {
                    if (letters >= 'a' && letters <= 'z')
                    {
                        lower++;
                    }
                    else if (letters >= 'A' && letters <= 'Z')
                    {
                        upper++;
                    }
                    else if (letters >= ' ' && letters <= '@')
                    {
                        lower++;
                        upper++;
                    }
                }
                if (lower > 0 && upper == 0)
                {
                    lowerCase.Add(word);
                }
                else if (lower == 0 && upper > 0)
                {
                    upperCase.Add(word);

                }
                else if (lower > 0 && upper > 0)
                {
                    mixedCase.Add(word);
                }

                upper = 0;
                lower = 0;
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
