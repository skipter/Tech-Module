using System;
namespace p._5_BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double numberOfBeatsInSeconds = double.Parse(Console.ReadLine());

            double bars = Math.Round(numberOfBeatsInSeconds * 0.25, 1);
            double totalSeconds = ((int)numberOfBeatsInSeconds * 60 / (int)beatsPerMinute);
            int minutes = (int) totalSeconds / 60;
            double seconds = totalSeconds % 60;

            Console.WriteLine("{0} bars - {1}m {2}s", Math.Round(bars, 1), minutes, Math.Floor(seconds));

        }
    }
}
