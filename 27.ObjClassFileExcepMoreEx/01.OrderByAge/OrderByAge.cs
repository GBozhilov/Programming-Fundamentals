using System;
using System.Collections.Generic;
using System.Linq;

public class OrderByAge
{
    public static void Main()
    {
        var people = new List<Person>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("End"))
            {
                break;
            }

            var personParams = inputLine.Split(' ');

            var name = personParams[0];
            var id = personParams[1];
            var age = int.Parse(personParams[2]);

            var newPerson = new Person() { Name = name, ID = id, Age = age };

            people.Add(newPerson);
        }

        foreach (var person in people.OrderBy(p => p.Age))
        {
            Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
        }
    }
}

public class Person
{
    public string Name { get; set; }

    public string ID { get; set; }

    public int Age { get; set; }
}