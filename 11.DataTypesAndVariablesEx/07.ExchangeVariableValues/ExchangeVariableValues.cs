using System;

public class ExchangeVariableValues
{
    public static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");

        var temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
    }
}