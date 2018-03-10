using System;
using System.Collections.Generic;
using System.Linq;

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
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
        }
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

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var studentInfo = Console.ReadLine()
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