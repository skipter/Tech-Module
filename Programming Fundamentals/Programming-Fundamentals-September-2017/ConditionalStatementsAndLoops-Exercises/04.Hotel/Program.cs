namespace Hotel
{
    using System;
    public class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightToStay = int.Parse(Console.ReadLine());

            double studioRoom = 0;
            double doubleRoom = 0;
            double suiteRoom = 0;
            switch (month)
            {
                case "May":
                case "October":
                    studioRoom = 50;
                    doubleRoom = 65;
                    suiteRoom = 75;
                    break;
                case "June":
                case "September":
                    studioRoom = 60;
                    doubleRoom = 72;
                    suiteRoom = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    studioRoom = 68;
                    doubleRoom = 77;
                    suiteRoom = 89;
                    break;
            }

            if (month.Equals("May") && nightToStay > 7 || month.Equals("October") && nightToStay > 7)
            {
                studioRoom = studioRoom - (studioRoom * 0.05);
            }
            if (nightToStay > 14 && month.Equals("June") || nightToStay > 14 && month.Equals("September"))
            {
                doubleRoom = doubleRoom - (doubleRoom * 0.10);
            }
            if (nightToStay > 14 && month.Equals("July") || nightToStay > 14 && month.Equals("August") || nightToStay > 14 && month.Equals("December")) {
                suiteRoom = suiteRoom - (suiteRoom * 0.15);
            }

            double totalPriceStudio = studioRoom * nightToStay;
            double totalPriceDouble = doubleRoom * nightToStay;
            double totalPriceSuite = suiteRoom * nightToStay;

            if (month.Equals("September") && nightToStay > 7 || nightToStay > 7 && month.Equals("October"))  
            {
                totalPriceStudio = totalPriceStudio - studioRoom;
            }
            Console.WriteLine("Studio: {0:F2} lv.", totalPriceStudio);
            Console.WriteLine("Double: {0:F2} lv.",totalPriceDouble);
            Console.WriteLine("Suite: {0:F2} lv.",totalPriceSuite);
        }
    }
}
