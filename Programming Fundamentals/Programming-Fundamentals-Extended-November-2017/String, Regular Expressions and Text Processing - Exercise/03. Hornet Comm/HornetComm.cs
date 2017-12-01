namespace _03.Hornet_Comm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class HornetComm
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<string> message = new List<string>();
            List<string> broadcast = new List<string>();
            string privatePattern = @"^([0-9]+) <-> ([a-zA-Z0-9]+)$";
            string broadcastPattern = @"^([^0-9]+) <-> ([a-zA-Z0-9]+)$";

            while (input != "Hornet is Green")
            {
                var privatee = Regex.Match(input, privatePattern);
                var broadcastMes = Regex.Match(input, broadcastPattern);

                if (privatee.Success)
                {
                    string temp = privatee.Groups[1].ToString();
                    temp = string.Join("", temp.ToCharArray().Reverse().ToArray());
                    message.Add(temp + " -> " + privatee.Groups[2].ToString());
                }

                if (broadcastMes.Success)
                {
                    string temp = broadcastMes.Groups[2].ToString();
                    string tempResult = String.Empty;
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (char.IsLower(temp[i]))
                        {
                            tempResult += temp[i].ToString().ToUpper();
                        }
                        else if (char.IsUpper(temp[i]))
                        {
                            tempResult += temp[i].ToString().ToLower();
                        }
                        else
                        {
                            tempResult += temp[i].ToString();
                        }
                    }
                    broadcast.Add(tempResult + " -> " + broadcastMes.Groups[1]);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(String.Join(Environment.NewLine, broadcast));
            }

            Console.WriteLine("Messages:");
            if (message.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(String.Join(Environment.NewLine, message));
            }
        }
    }
}
