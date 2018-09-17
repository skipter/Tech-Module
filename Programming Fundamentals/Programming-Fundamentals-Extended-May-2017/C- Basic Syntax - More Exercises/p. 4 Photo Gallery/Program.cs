using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p._4_Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictureName = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double bytes = double.Parse(Console.ReadLine());
            int widthPic = int.Parse(Console.ReadLine());
            int heightPic = int.Parse(Console.ReadLine());

            double megabyte = bytes / 1000000;
            double kylobytes = bytes / 1000;
            string mb = "MB";
            string b = "B";
            string kb = "KB";
                        
            string pictureType = "";

            if (widthPic > heightPic)
            {
                pictureType = "landscape";
            }
            else if (widthPic < heightPic)
            {
                pictureType = "portrait";
            }
            else if (widthPic == heightPic)
            {
                pictureType = "square";
            }

            Console.WriteLine("Name: DSC_{0:D4}.jpg", pictureName);
            Console.WriteLine("Date Taken: {0}/{1:D2}/{2} {3:D2}:{4:D2}", day, month, year, hours, minutes);
            if (bytes < 1000)
            {
            Console.WriteLine("Size: {0}{1}", bytes, b);
            }
            else if (bytes >= 1000 && bytes < 1000000)
            {            
            Console.WriteLine("Size: {0}{1}", kylobytes, kb);
            }
            else if (bytes >= 1000000)
            {
            Console.WriteLine("Size: {0}{1}", Math.Round(megabyte, 1), mb);
            }            
            Console.WriteLine("Resolution: {0}x{1} ({2})", widthPic, heightPic, pictureType);
            


        }
    }
}
