using System;
using System.Text;

public class MakeAWord
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var word = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            var currentSymbol = Console.ReadLine()[0];

            word.Append(currentSymbol);
        }

        Console.WriteLine($"The word is: {word}");
    }
}