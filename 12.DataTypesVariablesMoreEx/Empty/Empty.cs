﻿using System;
using System.Text;

public class BalancedBrackets
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var balance = true;
        var brackets = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine();

            if (line == "(" || line == ")")
            {
                brackets.Append(line);
            }
        }

        for (int i = 0; i < brackets.Length; i++)
        {
            if (brackets.Length % 2 != 0)
            {
                balance = false;
                break;
            }

            var isPreviousClosed = i % 2 == 0 && brackets[i] == ')';
            var isNextOpened = i % 2 != 0 && brackets[i] == '(';

            if (isPreviousClosed || isNextOpened)
            {
                balance = false;
                break;
            }
        }

        Console.WriteLine(balance ? "BALANCED" : "UNBALANCED");
    }
}