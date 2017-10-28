namespace _02.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class HornetComm
    {
        public static void Main()
        {
            List<string> broadcast = new List<string>();
            List<string> messages = new List<string>();
            string input = Console.ReadLine();

            while (input != "Hornet is Green")
            {
                var text = Console.ReadLine()
                                .Split(new string[] {"<->"}
                                , StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();

                // While the enter is invalid, read input again. When you remove <-> with separator will remain only two tokens.
                if (text.Length != 2)
                {
                    input = Console.ReadLine();
                    text = input.Split(new string[] { "<->" }
                        , StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    continue;
                }

                var left = text[0];
                var right = text[1];

                if (left.All(char.IsDigit) && right.All(char.IsLetterOrDigit))
                {
                    // TODO
                }
                else if (left.All(c => !char.IsDigit(c)) && right.All(char.IsLetterOrDigit))
                {
                    //TODO
                }




                input = Console.ReadLine();
            }
        }
    }
}
