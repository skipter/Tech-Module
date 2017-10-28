namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var salesByTown = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                Sale currentSale = new Sale().ReadSale();

                string town = currentSale.Town;
                double totalSum = currentSale.Price * currentSale.Quantity;

                if (!salesByTown.ContainsKey(town))
                {
                    salesByTown[town] = 0d;
                }
                salesByTown[town] += totalSum;
            }

            foreach (var town in salesByTown)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:F2}");
            }
        }
    }

    public class Sale
    {
        public string Town  { get; set; }
        public string Product  { get; set; }
        public double Price  { get; set; }
        public double Quantity  { get; set; }

        public Sale ReadSale()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Sale sale = new Sale() { Town = input[0], Product = input[1],
                                    Price = double.Parse(input[2]), Quantity = double.Parse(input[3]) };

            return sale;
        }
    }
}

     
    


    

