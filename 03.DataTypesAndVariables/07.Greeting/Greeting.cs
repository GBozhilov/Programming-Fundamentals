using System;

public class Greeting
{
    public static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string ageStr = Console.ReadLine();

        int age = int.Parse(ageStr);

        Console.WriteLine($"Hello, {firstName} {lastName}.\nYou are {age} years old.");
    }
}