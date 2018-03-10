using System;
using System.Collections.Generic;
using System.Linq;

public class TakeSkipRope
{
    public static void Main()
    {
        string encryptedMessage = Console.ReadLine(); ;

        char[] messageArr = encryptedMessage
            .ToCharArray();
        int[] numbers = messageArr
            .Where(x => char.IsDigit(x))
            .Select(x => int
            .Parse(x.ToString()))
            .ToArray();
        char[] nonNumbers = messageArr
            .Where(x => !char.IsDigit(x))
            .ToArray();

        List<int> takeList = new List<int>();
        List<int> skipList = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNum = numbers[i];

            if (i % 2 == 0)
            {
                takeList.Add(currentNum);
                continue;
            }

            skipList.Add(currentNum);
        }

        int totalSkip = 0;
        List<char> decryptedMessage = new List<char>();

        for (int i = 0; i < skipList.Count; i++)
        {
            int skipCount = skipList[i];
            int takeCount = takeList[i];

            char[] decryptedRange = nonNumbers
                .Skip(totalSkip)
                .Take(takeCount)
                .ToArray();

            decryptedMessage.AddRange(decryptedRange);
            totalSkip += skipCount + takeCount;
        }

        Console.WriteLine(string.Join("", decryptedMessage));
    }
}