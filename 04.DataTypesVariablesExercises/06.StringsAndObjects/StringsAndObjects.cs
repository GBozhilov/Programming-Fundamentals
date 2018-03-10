using System;

public class StringsAndObjects
{
    public static void Main()
    {
        string firstStr = "Hello";
        string secondStr = "World";
        object concatenateStr = firstStr + " " + secondStr;
        string objectToStr = (string)concatenateStr;

        Console.WriteLine(objectToStr);
    }
}