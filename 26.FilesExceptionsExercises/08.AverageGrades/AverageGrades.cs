using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class AverageGrades
{
    public static void Main()
    {
        List<Student> students = ReadStudents();

        students = SortStudents(students);

        PrintResult(students);
    }

    public static void PrintResult(List<Student> students)
    {
        var output = new StringBuilder();

        foreach (var student in students)
        {
            output.AppendLine($"{student.Name} -> {student.AverageGrade:F2}");
        }

        File.WriteAllText("output.txt", output.ToString());
    }

    public static List<Student> SortStudents(List<Student> students)
    {
        return students
            .Where(s => s.AverageGrade >= 5.00)
            .OrderBy(s => s.Name)
            .ThenByDescending(s => s.AverageGrade)
            .ToList();
    }

    public static List<Student> ReadStudents()
    {
        var students = new List<Student>();

        var lines = File.ReadAllLines("input.txt");

        foreach (var line in lines)
        {
            var studentInfo = line
                .Split(' ');

            var name = studentInfo.First();
            var grades = studentInfo
                .Skip(1)
                .Select(double.Parse)
                .ToArray();

            var newStudent = new Student()
            {
                Name = name,
                Grades = grades
            };

            students.Add(newStudent);
        }

        return students;
    }
}

public class Student
{
    public string Name { get; set; }

    public double[] Grades { get; set; }

    public double AverageGrade { get { return Grades.Average(); } }
}