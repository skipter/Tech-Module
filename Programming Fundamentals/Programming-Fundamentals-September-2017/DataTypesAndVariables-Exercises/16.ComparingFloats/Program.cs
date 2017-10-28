namespace _16.ComparingFloats
{
    using System;
    public class Program
    {
        static void Main()
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double difference = Math.Abs(numberA - numberB);
            bool isEquals = false; ;
            
            if (difference < eps)
            {
                isEquals = true;
            } else if (difference == eps)
            {
                isEquals = false;
            } else
            {
                isEquals = false;
            }
            Console.WriteLine(isEquals);
        }
    }
}
