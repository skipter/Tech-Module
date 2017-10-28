using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2.ElemntEqualIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] findTheEqualIndex = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string empryString = string.Empty;

            for (int cnt = 0; cnt < findTheEqualIndex.Length; cnt++)
            {
                if (cnt == findTheEqualIndex[cnt])
                {
                    empryString += cnt + " ";
                }
            }
            Console.WriteLine(empryString);
        }
    }
}
