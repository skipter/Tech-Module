using System;
public class PriceChangeAlert
{
    
    public static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double minorOrMajor = double.Parse(Console.ReadLine());
        double prices = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double diff = GetDifferenceProcents(prices, currentPrice);
            bool isSignificantDifference = IsDifference(diff, minorOrMajor);

            string priceAlert = GetDifference(currentPrice, prices, diff, isSignificantDifference);
            Console.WriteLine(priceAlert);
            prices = currentPrice;
        }
    }
    private static string GetDifference(double currentPrice, double prices, double difference, bool etherTrueOrFalse)
    {
        string priceAlert = String.Empty;

        if (difference == 0)
        {
            priceAlert = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!etherTrueOrFalse)
        {
            priceAlert = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", prices, currentPrice, difference * 100);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            priceAlert = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", prices, currentPrice, difference * 100);
        }
        else if (etherTrueOrFalse && (difference < 0))
        {
            priceAlert = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", prices, currentPrice, difference * 100);
        }
        return priceAlert;
    }

    private static bool IsDifference(double minorOrMajor, double isDiff)
    {
        if (Math.Abs(minorOrMajor) >= isDiff)
        {
            return true;
        }
        return false;
    }

    //Procents
    private static double GetDifferenceProcents(double price, double currentPrice)
    {
        double result = (currentPrice - price) / price;
        return result;
    }
}
