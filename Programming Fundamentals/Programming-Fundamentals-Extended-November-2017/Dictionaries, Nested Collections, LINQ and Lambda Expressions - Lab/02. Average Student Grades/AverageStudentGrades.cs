namespace _02.Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AverageStudentGrades
    {
        public static void Main()
        {
            int conter = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < conter; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                double grade = double.Parse(input[1]);
                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<double>());
                    studentsGrades[name].Add(grade);
                }
                else
                {
                    studentsGrades[name].Add(grade);
                }
            }
                        foreach (var item in studentsGrades)
            {
                var grades = item.Value;
                Console.Write($"{item.Key} -> ");
                foreach (var grade in grades)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():F2})");
            }
        }
    }
}
