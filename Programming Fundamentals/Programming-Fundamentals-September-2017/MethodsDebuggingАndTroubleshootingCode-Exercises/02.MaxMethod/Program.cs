namespace _02.MaxMethod
{
    using System;
    public class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNUmber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggerNum = GetMaxNumber(firstNumber, secondNUmber);
            if (biggerNum > thirdNumber)
            {
                Console.WriteLine(biggerNum);
            } else
            {
                Console.WriteLine(thirdNumber);
            }
        }
   
        public static int GetMaxNumber(int a, int b)
        {
            int bigger = 0;
            if (a > b)
            {
                bigger = a;
            } else 
            {
                bigger = b;
            } 
            return bigger;
        }
    }
}
