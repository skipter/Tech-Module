using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p._8_SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCharacters = int.Parse(Console.ReadLine());
            

            char currentChar = 'a';

            for (int i = 0; i < numberOfCharacters; i++)
            {
                int integerToChar = int.Parse(Console.ReadLine());

                switch (integerToChar)
                {
                    case 2:
                        currentChar = 'a';
                        Console.Write(currentChar);
                        break;
                    case 22:
                        currentChar = 'b';
                        Console.Write(currentChar);
                        break;
                    case 222:
                        currentChar = 'c';
                        Console.Write(currentChar);
                        break;
                    case 3:
                        currentChar = 'd';
                        Console.Write(currentChar);
                        break;
                    case 33:
                        currentChar = 'e';
                        Console.Write(currentChar);
                        break;
                    case 333:
                        currentChar = 'f';
                        Console.Write(currentChar);
                        break;
                    case 4:
                        currentChar = 'g';
                        Console.Write(currentChar);
                        break;
                    case 44:
                        currentChar = 'h';
                        Console.Write(currentChar);
                        break;
                    case 444:
                        currentChar = 'i';
                        Console.Write(currentChar);

                        break;
                    case 5:
                        currentChar = 'j';
                        Console.Write(currentChar);
                        break;
                    case 55:
                        currentChar = 'k';
                        Console.Write(currentChar);
                        break;
                    case 555:
                        currentChar = 'l';
                        Console.Write(currentChar);
                        break;
                    case 6:
                        currentChar = 'm';
                        Console.Write(currentChar);
                        break;
                    case 66:
                        currentChar = 'n';
                        Console.Write(currentChar);
                        break;
                    case 666:
                        currentChar = 'o';
                        Console.Write(currentChar);
                        break;
                    case 7:
                        currentChar = 'p';
                        Console.Write(currentChar);
                        break;
                    case 77:
                        currentChar = 'q';
                        Console.Write(currentChar);
                        break;
                    case 777:
                        currentChar = 'r';
                        Console.Write(currentChar);
                        break;
                    case 7777:
                        currentChar = 's';
                        Console.Write(currentChar);
                        break;
                    case 8:
                        currentChar = 't';
                        Console.Write(currentChar);
                        break;
                    case 88:
                        currentChar = 'u';
                        Console.Write(currentChar);
                        break;
                    case 888:
                        currentChar = 'v';
                        Console.Write(currentChar);
                        break;
                    case 9:
                        currentChar = 'w';
                        Console.Write(currentChar);
                        break;
                    case 99:
                        currentChar = 'x';
                        Console.Write(currentChar);
                        break;
                    case 999:
                        currentChar = 'y';
                        Console.Write(currentChar);
                        break;
                    case 9999:
                        currentChar = 'z';
                        Console.Write(currentChar);
                        break;
                    case 0:
                        currentChar = ' ';
                        Console.Write(currentChar);
                        break;
                }
            }
            
            

        }
    }
}
