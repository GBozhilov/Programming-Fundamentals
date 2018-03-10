using System;

public class SMSTyping
{
    public static void Main()
    {
        var commandsCount = int.Parse(Console.ReadLine());

        var message = string.Empty;

        for (int i = 0; i < commandsCount; i++)
        {
            var command = Console.ReadLine();

            var mainDigit = int.Parse(command[0].ToString());
            var offset = (mainDigit - 2) * 3;

            if (mainDigit == 8 || mainDigit == 9)
            {
                offset++;
            }

            var letterIndex = offset + command.Length - 1;

            message = mainDigit != 0 ? message += (char)(97 + letterIndex) : message += " ";
        }

        Console.WriteLine(message);
    }
}