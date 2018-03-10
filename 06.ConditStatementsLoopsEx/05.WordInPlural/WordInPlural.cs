using System;
using System.Text;

public class WordInPlural
{
    public static void Main()
    {
        var word = Console.ReadLine();

        var wordInPlural = new StringBuilder();

        if (word.EndsWith("y"))
        {
            wordInPlural.Append(word.Remove(word.Length - 1) + "ies");
        }
        else if (word.EndsWith("ch") || word.EndsWith("sh") || word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z"))
        {
            wordInPlural.Append(word + "es");
        }
        else
        {
            wordInPlural.Append(word + "s");
        }

        Console.WriteLine(wordInPlural);
    }
}