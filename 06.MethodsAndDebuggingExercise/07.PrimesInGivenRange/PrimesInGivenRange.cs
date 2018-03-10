using System;

public class PrimesInGivenRange
{
    public static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        PrintPrimesInRange(firstNum, secondNum);
    }

    static void PrintPrimesInRange(int firstNum, int secondNum)
    {
        bool temp = true;

        if (firstNum < 2)
            firstNum = 2;

        for (int currentNum = firstNum; currentNum <= secondNum; currentNum++)
        {
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(currentNum);
            bool isPrime = true;

            while (divider <= maxDivider)
            {
                if (currentNum % divider == 0)
                {
                    isPrime = false;
                    break;
                }

                divider++;
            }

            if (isPrime && temp)
            {
                Console.Write(currentNum);
                temp = false;
            }
            else if (isPrime)
            {
                Console.Write($", {currentNum}");
            }
        }

        Console.WriteLine();
    }
}