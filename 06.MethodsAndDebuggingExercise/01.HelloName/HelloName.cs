using System;

public class HelloName
{
    public static void Main()
    {
        string name = Console.ReadLine();

        PrintGreeting(name);
    }

    static void PrintGreeting(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}