using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        var start = int.Parse(Console.ReadLine());
        var end = int.Parse(Console.ReadLine());

        var primeNums = FindPrimesInRange(start, end);

        Console.WriteLine(string.Join(", ", primeNums));
    }

    public static List<int> FindPrimesInRange(int start, int end)
    {
        var primeNums = new List<int>();

        for (int currentNum = start; currentNum <= end; currentNum++)
        {
            if (currentNum == 0 || currentNum == 1)
            {
                continue;
            }

            var isPrime = true;
            var divider = 2;
            var maxDivider = (int)Math.Sqrt(currentNum);

            while (divider <= maxDivider)
            {
                if (currentNum % divider == 0)
                {
                    isPrime = false;
                    break;
                }

                divider++;
            }

            if (isPrime)
            {
                primeNums.Add(currentNum);
            }
        }

        return primeNums;
    }
}