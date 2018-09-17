namespace ForeignLanguages
{
    using System;
    public class Program
    {
        static void Main()
        {
            string country = Console.ReadLine();

            if (country.Equals("USA") || country.Equals("England"))
            {
                Console.WriteLine("English");
            } else if (country.Equals("Spain") || country.Equals("Argentina") || country == "Mexico")
            {
                Console.WriteLine("Spanish");
            } else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

    


