namespace _04.Elevator
{
    using System;
    public class Program
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int peopleCapacity = int.Parse(Console.ReadLine());

            int courses = numberOfPeople / peopleCapacity;
            int lastCours = numberOfPeople % peopleCapacity;
            if (lastCours > 0)
            {
                courses += 1;
            }
            Console.WriteLine(courses);
        }
    }
}
