using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var crypted = Console.ReadLine().ToCharArray();
            int[] intForPosition = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string output = string.Empty;
            for (int cnt = 0; cnt < crypted.Length; cnt++)
            {
                if (intForPosition[cnt] % 2 == 0)
                {
                    crypted[cnt] = (char)((int)crypted[cnt] - intForPosition[cnt]);
                } else
                {
                    crypted[cnt] = (char)((int)crypted[cnt] + intForPosition[cnt]);
                }
            }
            Console.WriteLine(String.Join("", crypted));
        }
    }
}
