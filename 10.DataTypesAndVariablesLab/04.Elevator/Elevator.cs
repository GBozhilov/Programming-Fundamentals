using System;

public class Elevator
{
    public static void Main()
    {
        var people = int.Parse(Console.ReadLine());
        var elevatorCapacity = int.Parse(Console.ReadLine());

        var courses = (int)Math.Ceiling((double)people / elevatorCapacity);

        Console.WriteLine(courses);
    }
}