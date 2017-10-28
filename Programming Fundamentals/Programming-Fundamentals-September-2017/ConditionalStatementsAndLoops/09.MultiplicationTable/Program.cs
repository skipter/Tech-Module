namespace MultiplicationTable
{
    using System;
    public class Program
    {
        static void Main()
        {
            int multiplaer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", multiplaer, i, multiplaer * i);
            }
        }
    }
}
