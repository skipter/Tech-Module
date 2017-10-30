namespace _04.Weather
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;
    public class Weather
    {
        public static void Main()
        {
            Dictionary<string, double> cityWithTemp = new Dictionary<string, double>();
            Dictionary<string, string> cityWithWeather = new Dictionary<string, string>();
            List<int> nlist = new List<int>();
            string pattern = "([A-Z]{2})([0-9.]+)([a-zA-Z]+)\\|";
            String input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    string city = match.Groups[1].Value;
                    double temp = double.Parse(match.Groups[2].Value);
                    string weather = match.Groups[3].Value;

                    cityWithTemp[city] = temp;
                    cityWithWeather[city] = weather;

                }
                input = Console.ReadLine();
            }
            Dictionary<string, double> sortedDictionryByTemp = cityWithTemp.OrderBy(c => c.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var cityy in sortedDictionryByTemp)
            {
                Console.WriteLine($"{cityy.Key} => {cityy.Value} => {cityWithWeather[cityy.Key]}");
            }
        }
    }
}
