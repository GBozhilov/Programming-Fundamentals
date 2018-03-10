using System;
using System.Text;

public class DecryptingMessage
{
    public static void Main()
    {
        var key = int.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());

        var message = new StringBuilder();

        while (n > 0)
        {
            var currentSymbol = Console.ReadLine()[0];

            var appendSymbol = (char)(currentSymbol + key);
            message.Append(appendSymbol);

            n--;
        }

        Console.WriteLine(message);
    }
}