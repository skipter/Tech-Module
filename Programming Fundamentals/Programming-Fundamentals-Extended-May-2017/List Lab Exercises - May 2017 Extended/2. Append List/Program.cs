using System;
using System.Collections.Generic;
using System.Linq;
namespace _2.Append_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Console.ReadLine().Split('|').ToList();
            var result = new List<int>();

            for (int cnt = 0; cnt < values.Count; cnt++)
            {
                var index = values[cnt].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                index.Reverse();
                foreach (var num in index)
                {
                    result.Add(num);
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }    
    }
}
