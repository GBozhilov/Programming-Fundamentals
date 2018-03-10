using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExamPreparation
{
    public sealed class Student
    {
        public Student(string name)
        {
            this.Name = name;
            this.Dates = new List<string>();
            this.Comments = new List<string>();
        }

        public string Name { get; private set; }

        public List<string> Dates { get; set; }

        public List<string> Comments { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(this.Name);
            output.AppendLine("Comments:");

            foreach (var comment in this.Comments)
            {
                output.AppendLine($"- {comment}");
            }

            output.AppendLine("Dates attended:");
            foreach (var date in this.Dates.OrderBy(d => d))
            {
                output.AppendLine($"-- {date}");
            }

            return output.ToString().Trim();
        }
    }

    public sealed class Preparation
    {
        public static void Main()
        {
            string datesInput = Console.ReadLine();
            SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();

            while (datesInput != "end of dates")
            {
                string[] tokens = datesInput.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                IEnumerable<string> dates = tokens.Skip(1);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new Student(name));
                }

                foreach (var date in dates)
                {
                    students[name].Dates.Add(date);
                }

                datesInput = Console.ReadLine();
            }

            string commentsInput = Console.ReadLine();

            while (commentsInput != "end of comments")
            {
                string[] tokens = commentsInput.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string comment = tokens[1];

                if (students.ContainsKey(name))
                {
                    students[name].Comments.Add(comment);
                }

                commentsInput = Console.ReadLine();
            }

            foreach (var student in students)
            {
                Console.WriteLine(student.Value);
            }
        }
    }
}