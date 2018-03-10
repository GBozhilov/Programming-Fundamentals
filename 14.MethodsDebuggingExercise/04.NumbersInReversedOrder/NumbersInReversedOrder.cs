using System;
using System.Text;

public class NumbersInReversedOrder
{
    public static void Main()
    {
        var text = Console.ReadLine();

        PrintReversedText(text);
    }

    public static void PrintReversedText(string text)
    {
        var reversedText = new StringBuilder();

        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedText.Append(text[i]);
        }

        Console.WriteLine(reversedText);
    }
}