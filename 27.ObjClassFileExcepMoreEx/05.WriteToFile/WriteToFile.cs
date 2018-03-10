﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class WriteToFile
{
    public static void Main()
    {
        var inputText = File.ReadAllText("sample_text.txt");

        var punctuationMarks = new char[] { '.', ',', '!', '?', ':' };
        var resultList = new List<char>();

        foreach (var symbol in inputText)
        {
            if (!punctuationMarks.Contains(symbol))
            {
                resultList.Add(symbol);
            }
        }

        File.WriteAllText("output.txt", string.Join(string.Empty, resultList));
        Console.WriteLine(string.Join(string.Empty, resultList));
    }
}