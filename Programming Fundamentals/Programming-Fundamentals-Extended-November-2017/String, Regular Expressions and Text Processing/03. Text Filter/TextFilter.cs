namespace _03.Text_Filter
{
    using System;
    using System.Linq;
    public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new char[] { ',', ' ', }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();

            foreach (var w in bannedWords)
            {
                string str = new string('*', w.Length);
                text = text.Replace(w, str);
            }
            Console.WriteLine(text);
        }
    }
}
