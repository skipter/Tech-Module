using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.BallisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split(' ');

            int x = 0;
            int y = 0;

            for (int cnt = 0; cnt < commands.Length; cnt++)
            {
                if (commands[cnt] == "up")
                {
                    y += Convert.ToInt32(commands[cnt + 1]);
                }
                if (commands[cnt] == "down")
                {
                    y -= Convert.ToInt32(commands[cnt + 1]);
                }
                if (commands[cnt] == "left")
                {
                    x -= Convert.ToInt32(commands[cnt + 1]);                    
                }
                if (commands[cnt] == "right")
                {
                    x += Convert.ToInt32(commands[cnt + 1]);                   
                }
            }            
                if (cordinates[0] == x && cordinates[1] == y)
            {
                Console.WriteLine("firing at [{0}, {1}]", cordinates[0], cordinates[1]);
                Console.WriteLine("got 'em!");
            } else
            {
                Console.WriteLine("firing at [{0}, {1}]", x, y);
                Console.WriteLine("better luck next time...");
            }
           
        }
    }
}
