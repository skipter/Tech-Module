namespace _19.TheaThePhotographer
{
    using System;
    public class Program
    {
        static void Main()
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTimeForPicture = long.Parse(Console.ReadLine());
            long filterFactorPercent = long.Parse(Console.ReadLine());
            long timeToUploadPicture = long.Parse(Console.ReadLine());

            //Filtering good/bad pictures
            double notGoodPictures = Math.Ceiling((double)numberOfPictures * filterFactorPercent / 100);
            long uNusefulPicturesAfterFilterFactor = numberOfPictures - (int)notGoodPictures;
            long usefulPicturesAfterFilterFactor = numberOfPictures - uNusefulPicturesAfterFilterFactor;

            //Time for filtering
            long totalTimeForFilterInSeconds = numberOfPictures * filterTimeForPicture;

            long totalTimeForUploadInSeconds = usefulPicturesAfterFilterFactor * timeToUploadPicture;
            long totalTimeForWork = totalTimeForFilterInSeconds + totalTimeForUploadInSeconds;

            TimeSpan timeFormat = TimeSpan.FromSeconds(totalTimeForWork);
            string printTimeFormat = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
                t.Days,
                t.Hours,
                t.Minutes,
                t.Seconds);

            Console.WriteLine(printTimeFormat);
        }
    }
}

