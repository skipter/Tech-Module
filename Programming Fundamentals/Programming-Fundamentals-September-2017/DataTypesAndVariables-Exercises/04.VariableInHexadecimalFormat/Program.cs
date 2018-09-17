namespace _04.VariableInHexadecimalFormat
{
    using System;
    public class Program
    {
        static void Main()
        {
            string hexValue = Console.ReadLine();
            int number = Convert.ToInt32(hexValue, 16);
            Console.WriteLine(number.ToString());
        }
    }
}
