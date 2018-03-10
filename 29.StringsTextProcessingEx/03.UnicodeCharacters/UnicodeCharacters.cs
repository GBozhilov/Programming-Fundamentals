using System;
using System.Text;

public class UnicodeCharacters
{
    public static void Main()
    {
        var input = Console.ReadLine();

        GetUnicodeString(input);
    }

    public static void GetUnicodeString(string str)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char symbol in str)
        {
            sb.Append("\\u");
            sb.Append(string.Format("{0:x4}", (int)symbol));
        }

        Console.WriteLine(sb.ToString());
    }
}