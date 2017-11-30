namespace _01.Reverse_String___StringBuilder
{
    using System;
    using System.Text;

    public class ReverseStringStringBuilder
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string result = String.Empty;

            StringBuilder sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0 ; i--)
            {
                sb.Append(input[i]);
            }
            result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
