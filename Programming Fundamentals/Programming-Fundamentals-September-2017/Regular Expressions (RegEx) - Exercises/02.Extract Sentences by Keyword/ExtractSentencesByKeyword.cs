using System;
using System.Text.RegularExpressions;

namespace _02.Extract_Sentences_by_Keyword
{
    public class ExtractSentencesByKeyword
    {
        public static void Main()               // 100/100
        {
            string word = Console.ReadLine();
            var input = Console.ReadLine().Split(new char[] { '.', '?', '!', }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = "\\b" + word + "\\b";
            Regex regex = new Regex(pattern);
            foreach (var sentance in input)
            {
                if (regex.IsMatch(sentance))
                {
                    Console.WriteLine(sentance.Trim());
                }
            }
        }
    }
}
                                // 80/100 ??
//          using System;
//          namespace _02.Extract_Sentences_by_Keyword
//          {
//              public class ExtractSentencesByKeyword
//              {
//                  public static void Main()
//                  {
//                      string word = Console.ReadLine();
//                      var input = Console.ReadLine().Split(new char[] { '.', '?', '!', }, StringSplitOptions.RemoveEmptyEntries);
//                      string extraWord = " " + word + " ";
//                      foreach (var sentance in input)
//                      {
//                          if (sentance.Contains(extraWord))
//                          {
//                              Console.WriteLine(sentance.Trim('.', '!', '?', ' '));
//                          }
//                      }
//                  }
//              }
//          }
