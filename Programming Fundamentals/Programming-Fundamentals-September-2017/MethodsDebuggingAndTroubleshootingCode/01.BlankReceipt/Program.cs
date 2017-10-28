namespace _01.BlankReceipt
{
    using System;
    public class Program
    {
        static void Main()
        {
            PrintReceipt();
        }
        public static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        public static void PringMiddle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        public static void PrintEnd()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
        public static void PrintReceipt()
        {
            PrintHeader();
            PringMiddle();
            PrintEnd();
        }
    }
}


