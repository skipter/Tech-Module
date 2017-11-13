namespace _04.Winning_Ticket
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class WinningTicket
    {
        public static void Main()
        {                                       // 80/100 - Points - Missing cases
            var tickets = Console.ReadLine()
                .Split(new char[] { ',', ' ', }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] patterns = { "\\@{6,9}", "\\#{6,9}", "\\${6,9}", "\\^{6,9}", };

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string left = ticket.Substring(0, 10);
                string right = ticket.Substring(10, 10);
                bool isMatch = false;
                for (int i = 0; i < patterns.Length; i++)
                {
                    if (Regex.IsMatch(left, patterns[i]) && Regex.IsMatch(right, patterns[i]))
                    {
                        string symbol = WinningSymbol(i);
                        int symbolMatch = SymbolCounter(left, Char.Parse(symbol));
                        if (symbolMatch == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {symbolMatch}{symbol} Jackpot!");
                            isMatch = true;
                            continue;
                        }
                        Console.WriteLine($"ticket \"{ticket}\" - {symbolMatch}{symbol}");
                        isMatch = true;
                        continue;
                    }
                }
                if (!isMatch)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }

        public static string WinningSymbol(int number)
        {
            switch (number)
            {
                case 0:
                    return "@";
                case 1:
                    return "#";
                case 2:
                    return "$";
                case 3:
                    return "^";
                default:
                    return "error";
            }
        }

        public static int SymbolCounter(string str, char letter)
        {
            int counter = 0;
            int maxCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == letter)
                {
                    counter++;
                    if (maxCount < counter)
                    {
                        maxCount = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            return maxCount;
        }
    }
}