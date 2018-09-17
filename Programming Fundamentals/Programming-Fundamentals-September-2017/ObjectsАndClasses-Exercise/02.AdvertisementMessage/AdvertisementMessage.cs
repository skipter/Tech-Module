namespace _02.AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    public class AdvertisementMessage
    {
        public static void Main()
        {
            List<string> phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." 
            };
            List<string> events = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" 
            };
            List<string> authors = new List<string>()
            {
               "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            List<string> cities = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            Random rnd = new Random();
            int numberPhrases = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberPhrases; i++)
            {
                int eve = rnd.Next(events.Count);
                string temp1 = events[eve];
                int auth = rnd.Next(authors.Count);
                string temp2 = authors[auth];
                int citi = rnd.Next(cities.Count);
                string temp3 = cities[citi];
                int prh = rnd.Next(phrases.Count);
                string temp4 = phrases[prh];

                Console.WriteLine("{0}{1}{2} - {3}",temp4, temp1, temp2, temp3);
            }
        }
    }
}
