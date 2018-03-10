using System;

public class CompareCharArrays
{
    public static void Main()
    {
        string[] firstArr = Console.ReadLine()
            .Split(' ');
        string[] secondArr = Console.ReadLine()
            .Split(' ');

        char[] firstLetters = new char[firstArr.Length];
        char[] secondLetters = new char[secondArr.Length];

        for (int i = 0; i < firstArr.Length; i++)
            firstLetters[i] = char.Parse(firstArr[i]);

        for (int i = 0; i < secondArr.Length; i++)
            secondLetters[i] = char.Parse(secondArr[i]);

        int shortLength = Math.Min(firstArr.Length, secondArr.Length);
        bool areDifferent = false;

        for (int i = 0; i < shortLength; i++)
        {
            if (firstLetters[i] > secondLetters[i])
            {
                Console.WriteLine(string.Join("", secondLetters));
                Console.WriteLine(string.Join("", firstLetters));
                areDifferent = true;
                break;
            }
            else if (firstLetters[i] < secondLetters[i])
            {
                Console.WriteLine(string.Join("", firstLetters));
                Console.WriteLine(string.Join("", secondLetters));
                areDifferent = true;
                break;
            }
        }

        if (!areDifferent && (firstLetters.Length <= secondLetters.Length))
        {
            Console.WriteLine(string.Join("", firstLetters));
            Console.WriteLine(string.Join("", secondLetters));
        }
        else if (!areDifferent && (firstLetters.Length > secondLetters.Length))
        {
            Console.WriteLine(string.Join("", secondLetters));
            Console.WriteLine(string.Join("", firstLetters));
        }
    }
}