using System;

public class GreaterOfTwoValues
{
    public static void Main()
    {
        string type = Console.ReadLine();

        if (type == "int")
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int greaterNum = GetMax(firstNum, secondNum);

            Console.WriteLine(greaterNum);
        }
        else if (type == "char")
        {
            char firstChar = Console.ReadLine()[0];
            char secondChar = Console.ReadLine()[0];

            char greaterChar = GetMax(firstChar, secondChar);

            Console.WriteLine(greaterChar);
        }
        else // type == "string"
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            string greaterString = GetMax(firstString, secondString);

            Console.WriteLine(greaterString);
        }
    }

    static int GetMax(int firstNum, int secondNum)
    {
        int result = Math.Max(firstNum, secondNum);

        return result;
    }

    static char GetMax(char firstChar, char secondChar)
    {
        char result = (char)Math.Max(firstChar, secondChar);

        return result;
    }

    static string GetMax(string firstString, string secondString)
    {
        if (firstString.CompareTo(secondString) > 0)
            return firstString;

        return secondString;
    }
}