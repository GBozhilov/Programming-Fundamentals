using System;
using System.Linq;

public class SumArraysOtherWay
{
    public static void Main()
    {
        int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int largegLength = Math.Max(firstArray.Length, secondArray.Length);

        for (int i = 0; i < largegLength; i++)
        {
            int firstValue = firstArray[i % firstArray.Length];
            int secondValue = secondArray[i % secondArray.Length];

            Console.Write("{0} ", firstValue + secondValue);
        }
    }
}