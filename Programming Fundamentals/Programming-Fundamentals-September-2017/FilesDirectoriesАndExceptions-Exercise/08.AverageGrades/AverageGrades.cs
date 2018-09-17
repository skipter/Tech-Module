namespace _08.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }
    public class AverageGrades
    {
        public static void Main()
        {
            // Number of students that will be entered in db.
            var numberStudents = File.ReadAllLines("studentsCount.txt");
            int enteredStudents = 0;
            foreach (var num in numberStudents)
            {
                enteredStudents = int.Parse(num);
            }

            var studentsGrades = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            List<Student> student = new List<Student>();
            
            foreach (var soldier in studentsGrades)
            {
                var inputData = soldier.Split(' ').ToList();
                var currentStudent = new Student();
                currentStudent.Name = inputData[0];                                       // Enter name from the List.
                currentStudent.Grades = inputData.Skip(1).Select(double.Parse).ToList(); // Take all the grades to 
                student.Add(currentStudent);  // add currentStud to List in Main()      //  List 'Grades' in Student Class
            }                                                                          //  Skip(1) cuz this is the index with name
        
            student.Where(g => g.AverageGrade >= 5.00).OrderBy(n => n.Name).ThenByDescending(n => n.AverageGrade).ToList()
                .ForEach(f => File.AppendAllText("output.txt", $"{f.Name} -> {f.AverageGrade:F2}" + Environment.NewLine));
            //First get studs with avergGrade big than 5.00, order by name, THEN by grade. If its ToList -> there is foreach method.

        }
    }
}
