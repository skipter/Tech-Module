namespace _01.Anonymous_Downsite
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    public class AnonymouDowsite
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());
            var sites = new List<string>();
            BigInteger totacClicks = 0;
            decimal pricePerClick = 0m;
            decimal totalSum = 0m;
            for (BigInteger i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string siteName = input[0];
                sites.Add(siteName);
                long siteVisits = long.Parse(input[1]);
                totacClicks += siteVisits;
                pricePerClick = decimal.Parse(input[2]);
                totalSum += siteVisits * pricePerClick;
            }
            Console.WriteLine(String.Join(Environment.NewLine, sites));
            Console.WriteLine($"Total Loss: {totalSum:F20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(key, n)}");
        }
    }
}
