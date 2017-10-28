namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class HandsOfCards
    {
        public static void Main()
        {
            var people = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                var inputLines = input
                    .Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var name = inputLines[0];
                var cards = inputLines[1].Trim().Split(new string[] { ", "}, StringSplitOptions.RemoveEmptyEntries);

                if(!people.ContainsKey(name))
                {
                   people.Add(name, new Dictionary<string, int>());
                    AddPersonCards(people[name], cards);
                }
                else
                {
                    AddPersonCards(people[name], cards);
                }

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine("{0}: {1}", person.Key, person.Value.Values.Sum());
            }
        }

        private static void AddPersonCards(Dictionary<string, int> person, string[] cards)
        {
            foreach (var card in cards)
            {
                if (!person.ContainsKey(card))
                {
                    person.Add(card, GetCardValue(card));
                }
            }
        }

        private static int GetCardValue(string card)
        {
            int power = 0;
            switch (card[0])
            {
                case '1':
                    power = 10;
                    break;
                case '2':
                    power = 2;
                    break;
                case '3':
                    power = 3;
                    break;
                case '4':
                    power = 4;
                    break;
                case '5':
                    power = 5;
                    break;
                case '6':
                    power = 6;
                    break;
                case '7':
                    power = 7;
                    break;
                case '8':
                    power = 8;
                    break;
                case '9':
                    power = 9;
                    break;
                case 'J':
                    power = 11;
                    break;
                case 'Q':
                    power = 12;
                    break;
                case 'K':
                    power = 13;
                    break;
                case 'A':
                    power = 14;
                    break;
            }

            switch (card[card.Length - 1])
            {
                case 'S':
                    power *= 4;
                    break;
                case 'H':
                    power *= 3;
                    break;
                case 'D':
                    power *= 2;
                    break;
                case 'C':
                    power *= 1;
                    break;
            }
            return power;
        }
    }
}
