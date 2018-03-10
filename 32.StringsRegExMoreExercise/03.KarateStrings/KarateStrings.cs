using System;
using System.Text;

public class KarateStrings
{
    public static void Main()
    {
        var text = new StringBuilder(Console.ReadLine());

        var strength = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != '>')
            {
                continue;
            }

            strength += int.Parse(text[i + 1].ToString());
            i++;

            while (strength > 0 && i < text.Length)
            {
                if (text[i] == '>')
                {
                    break;
                }

                text.Remove(i, 1);
                strength--;
            }

            i--;
        }

        Console.WriteLine(text);
    }
}