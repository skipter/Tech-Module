namespace CounterTheIntegers
{
    using System;
    public class Program
    {
        static void Main()
        {
            int integer = 0;
            int counter = 0;

            try
            {
                while ((int)integer == (int)integer)
                {
                    integer = int.Parse(Console.ReadLine());
                    counter++;
                }
            } catch
            {

            }
            Console.WriteLine(counter);
        }
    }
}
