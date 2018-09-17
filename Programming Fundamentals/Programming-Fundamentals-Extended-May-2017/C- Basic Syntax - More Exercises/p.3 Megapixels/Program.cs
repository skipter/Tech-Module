using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p._3_Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double pixels = (width * height);
            double diversion = pixels / 1000000;
            Console.WriteLine("{0}x{1} => {2}MP", width, height, Math.Round(diversion, 1));
        }
    }
}
