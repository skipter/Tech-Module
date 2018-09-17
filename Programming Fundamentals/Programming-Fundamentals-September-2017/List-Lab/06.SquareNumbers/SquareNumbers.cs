namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '|', ';', }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            List<double> result = new List<double>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    result.Add(numbers[i]);
                }
            }

            var resultOrder = result.OrderByDescending(num => num); // 100/100 in judge
            Console.WriteLine(string.Join(" ", resultOrder));

            //  result.Sort();                                  With this way 100/100                                                      
            //  result.Reverse();                               Trying with OrderByDescending....
            // Console.WriteLine(string.Join(" ", result));
        }
    }
}
