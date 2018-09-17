namespace _06.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    public class FixEmails
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("input.txt");
            File.Delete("output.txt");

            Dictionary<string, string> emailCordinats = new Dictionary<string, string>();

            int nameIndex = 0;
            int emailIndex = 1;

            while (lines[nameIndex] != "stop")
            {
                Add(lines[nameIndex], lines[emailIndex]);
                nameIndex += 2;
                emailIndex += 2;
            }

            foreach (var name in emailCordinats)
            {
                string output = $"{name.Key} -> {name.Value}" + Environment.NewLine;
                File.AppendAllText("output.txt", output);
            }

            void Add(string name, string email)
            {
                if (!emailCordinats.ContainsKey(name))
                {
                    if (!email.Contains(".us") || email.Contains(".uk"))
                    {
                        emailCordinats.Add(name, email);
                    }
                }
            }
        }
    }
}