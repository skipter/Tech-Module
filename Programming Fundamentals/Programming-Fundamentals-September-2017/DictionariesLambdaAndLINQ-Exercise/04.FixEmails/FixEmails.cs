namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FixEmails
    {
        public static void Main()
        {
            Dictionary<string, string> emailCordinats = new Dictionary<string, string>();
            string input;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                
                if (!emailCordinats.ContainsKey(input)) 
                {
                    if (!email.Contains(".us") || email.Contains(".uk"))
                    {
                        emailCordinats.Add(input, email);
                    }
                }
            }
            foreach (var name in emailCordinats)
            {
                Console.WriteLine("{0} -> {1}", name.Key, name.Value);
            }
        }
    }
}
