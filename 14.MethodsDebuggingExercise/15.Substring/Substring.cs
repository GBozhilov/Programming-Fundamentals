using System;

public class Substring
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char Search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            var currentSymbol = text[i];

            if (currentSymbol == Search)
            {
                hasMatch = true;

                int length = jump + 1;
                string matchedString = string.Empty;

                if (i + length <= text.Length)
                {
                    matchedString = text.Substring(i, length);
                }
                else
                {
                    matchedString = text.Substring(i);
                }

                Console.WriteLine(matchedString);

                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
