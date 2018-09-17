namespace MultiplicationTable_2._0
{
    using System;
    public class Program
    {
        static void Main()
        {
            int multiplaer = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            
            if (times > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", multiplaer, times, multiplaer * times);
            } else
            {
                for (int i = times; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", multiplaer, i, multiplaer * i);
                }
            }
        }
    }
}
