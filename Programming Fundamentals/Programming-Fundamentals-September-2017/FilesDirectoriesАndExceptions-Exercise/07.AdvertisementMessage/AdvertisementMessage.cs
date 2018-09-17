namespace _07.AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    public class AdvertisementMessage
    {
        public static void Main()
        {
            // Add info from files.
            string[] phrases = File.ReadAllLines("input.txt");
            string[] events = File.ReadAllLines("input_2.txt");
            string[] authors = File.ReadAllLines("input_3.txt");
            string[] cities = File.ReadAllLines("input_4.txt");

            // Add to lists.
            List<string> phrasesToList = new List<string>();
            foreach (var phrase in phrases)
            {
                phrasesToList = phrase
                   .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                   .ToList();
            }

            List<string> eventsToList = new List<string>();
            foreach (var eventt in events)
            {
                eventsToList = eventt
           .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                   .ToList();

            }

            List<string> authorsToList = new List<string>();
            foreach (var author in authors)
            {
                authorsToList = author
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            List<string> citiesToList = new List<string>();
            foreach (var city in cities)
            {
                citiesToList = city
                   .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                   .ToList();
            }

            string[] numToAds = File.ReadAllLines("numberForAds.txt");
            File.Delete("output.txt");
            Random rnd = new Random();
            string output = String.Empty;
            foreach (var num in numToAds)
            {

                int numberPhrases = int.Parse(num);

                for (int i = 0; i < numberPhrases; i++)
                {
                    int eve = rnd.Next(eventsToList.Count);
                    string temp1 = eventsToList[eve];

                    int auth = rnd.Next(authorsToList.Count);
                    string temp2 = authorsToList[auth];

                    int citi = rnd.Next(citiesToList.Count);
                    string temp3 = citiesToList[citi];

                    int prh = rnd.Next(phrasesToList.Count);
                    string temp4 = phrasesToList[prh];

                    output = $"{temp4} {temp1} {temp2} - {temp3}" + Environment.NewLine;
                    File.AppendAllText("output.txt", output);
                }
            }
        }
    }
}

