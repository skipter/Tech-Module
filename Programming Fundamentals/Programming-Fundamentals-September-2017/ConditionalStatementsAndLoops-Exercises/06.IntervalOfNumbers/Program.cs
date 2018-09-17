namespace IntervalOfNumbers
{
    using System;
    public class Program
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());

            if (startNumber < stopNumber)
            {
                for (int i = startNumber; i <= stopNumber; i++)
                    Console.WriteLine(i);
            }
            else if (startNumber > stopNumber)
            {
                for (int i = stopNumber; i <= startNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
