namespace _04.Winning_Ticket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WinningTicket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(new char[] { ',', ' ', }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string pattern = @"([$@#^]+)";
            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    string left = ticket.Substring(0, 10);
                    string right = ticket.Substring(10, 10);
                    int leftNum = 0;
                    int rightNum = 0;
                    int equalIndexSymbol = 0;
                    Dictionary<string, int> ahh = new Dictionary<string, int>();
                    ahh.Add("@", 0);
                    ahh.Add("#", 0);
                    ahh.Add("$", 0);
                    ahh.Add("^", 0);

                    
            }
        }
    }
}
