namespace DifferentNumbers
{
    using System;
    public class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool check = false;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = a; k <= b; k++)
                    {
                        for (int l = a; l <= b; l++)
                        {
                            for (int m = a; m <= b; m++)
                            {
                                if (a <= i && i < j && j < k && k < l && l < m && m <= b)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4}", i, j, k, l, m);
                                    check = true;
                                }
                            }
                        }
                    }
                }
            }
            if (check == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
