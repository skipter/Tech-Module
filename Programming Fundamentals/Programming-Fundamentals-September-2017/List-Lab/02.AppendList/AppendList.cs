namespace _02.AppendList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendList
    {
        public static void Main()
        {


            List<string> input = Console.ReadLine()
                  .Split('|')
                  .ToList();

            string result = String.Empty;

            for (int i = input.Count - 1; i >= 0 ; i--)
            {
                string tokens = input[i];
                List<string> resultList = tokens
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int k = 0; k < resultList.Count; k++)
                {
                    result += resultList[k] + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
