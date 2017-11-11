namespace _01.Anonymous_Downsite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    public class AnonymousDownsite
    {
        public static void Main()
        {
            List<string> webSiteNames = new List<string>();
            int websitesDown = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            for (int i = 0; i < websitesDown; i++)
            {
                var incomeData = Console.ReadLine().Split(' ').ToList();
                string siteName = incomeData[0];
                long siteVisits = long.Parse(incomeData[1]);
                webSiteNames.Add(siteName);
                decimal pricePerVisit = decimal.Parse(incomeData[2]);
                totalLoss += siteVisits * pricePerVisit;
            }
            Console.WriteLine(String.Join(Environment.NewLine, webSiteNames));
            Console.WriteLine($"Total Loss: { totalLoss:F20} ");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey, websitesDown)}");
        }
    }
}
