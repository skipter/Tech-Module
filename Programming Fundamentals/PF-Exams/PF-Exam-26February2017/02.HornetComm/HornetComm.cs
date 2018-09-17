namespace _02.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    public class HornetComm
    {
        public static void Main()
        {                                                   // 90/100 Points - Missing Case!
            List<string> broadCasts = new List<string>();
            List<string> messages = new List<string>();
            string input = Console.ReadLine();
            while (input != "Hornet is Green")
            {
                var tokens = input
                    .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string left = tokens[0];
                string right = tokens[1];

                if (left.All(char.IsDigit) && (right.All(char.IsLetterOrDigit)))
                {
                    left = Reverse(left);
                    messages.Add(left + " -> " + right);
                }
                else if (!left.All(char.IsDigit) && (right.All(char.IsLetterOrDigit)))
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < right.Length; i++)
                    {
                        if (Char.IsUpper(right, i))
                        {
                            sb.Append(char.ToLower(right[i]));
                        }
                        else if (Char.IsLower(right, i))
                        {
                            sb.Append(char.ToUpper(right[i]));
                        }
                        else
                        {
                            sb.Append(right[i]);
                        }
                    }

                    broadCasts.Add(sb + " -> " + left);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadCasts.Count > 0)
            {
                foreach (var broad in broadCasts)
                {
                    Console.WriteLine(broad);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        public static string Reverse(string str)
        {
            char[] reverse = str.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }
    }
}

