using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> lowerCase = new List<string>();
            List <string> upperCase = new List<string>();
            List <string> mixedCase = new List<string>();
            List<string> totalWords = Console.ReadLine().Split(new char[] { ' ', '!', '(', ')', ',', '.', '\'',
                '\"', ':', ';', '[', ']', '\\', '/' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string currentWord = string.Empty;

            for (int i = 0; i < totalWords.Count; i++)
            {
                if (totalWords[i].All(char.IsLower))
                {
                    lowerCase.Add(totalWords[i]);
                } else if (totalWords[i].All(char.IsUpper))
                {
                    upperCase.Add(totalWords[i]);
                } else
                {
                    mixedCase.Add(totalWords[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase )}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
            

        }
    }
}
