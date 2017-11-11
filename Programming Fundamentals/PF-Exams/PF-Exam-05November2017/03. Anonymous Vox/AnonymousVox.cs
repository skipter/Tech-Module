namespace _03.Anonymous_Vox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnonymousVox
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split(' ').ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                var tokens = input.Split(' ');
                string command = tokens[0];
                int num = int.Parse(tokens[1]);
                int num2 = int.Parse(tokens[2]);

                if (command == "merge")
                {
                    if (num < 0)
                    {
                        num = 0;
                    }
                    if (num2 >= data.Count)
                    {
                        num2 = data.Count - 1;
                    }
                    for (int i = num; i < num2 - 1; i++)
                    {
                        data[num] += data[num2 - 1];
                        data.RemoveAt(num + 1);
                    }
                }
                else 
                {
                    int index = num;
                    int partitions = num2;
                    string divide = data[index];
                    int divCounter = divide.Length / partitions;
                    string addElement = null;

                    data.RemoveAt(index);
                    var result = new List<string>();

                    for (int i = 0; i < partitions; i++)
                    {
                        addElement = divide.Substring(0, divCounter);
                        result.Add(addElement);
                        divide = divide.Substring(divCounter);
                    }
                    if (divide != "" && divide != null)
                    {
                        result[result.Count - 1] += divide;
                    }
                    data.InsertRange(index, result);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", data));
        }
    }
}
