using System;

public class EmployeeData
{
    public static void Main()
    {
        string firstName = Console.ReadLine(); ;
        string lastName = Console.ReadLine(); ;
        byte age = byte.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        long personalNumber = long.Parse(Console.ReadLine());
        uint employeeNumber = uint.Parse(Console.ReadLine());

        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Personal ID: {personalNumber}");
        Console.WriteLine($"Unique Employee number: {employeeNumber}");
    }
}