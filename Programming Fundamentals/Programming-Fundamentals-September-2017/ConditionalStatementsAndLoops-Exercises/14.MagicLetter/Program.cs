namespace MagicLetter
{
    using System;
    public class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine().ToLower());
            char secondChar = char.Parse(Console.ReadLine().ToLower());
            char thurdChar = char.Parse(Console.ReadLine().ToLower());


            for (char i = firstChar; i <= secondChar; i++)
            {
                for (char j = firstChar; j <= secondChar; j++)
                {
                    for (char k = firstChar; k <= secondChar; k++)
                    {
                        if (!(i == thurdChar || j == thurdChar || k == thurdChar))
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                        }
                    }
                }
            }
        }
    }
}
