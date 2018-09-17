using System;
namespace _16.ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');           
            bool IsSymmetrical = false;
            int n = firstArray.Length / 2;

            for (int cnt = 0; cnt < n; cnt++)
            {
               if (firstArray[cnt] == firstArray[firstArray.Length - 1 - cnt])
                    {
                        IsSymmetrical = true;
                    } else
                    {
                        IsSymmetrical = false;
                    break;
                    }
            }
            if (IsSymmetrical)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
        }
    }
}
