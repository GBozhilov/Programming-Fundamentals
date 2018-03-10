using System;

public class SumArrays
{
    public static void Main()
    {
        string[] arr1 = Console.ReadLine().Split();
        string[] arr2 = Console.ReadLine().Split();

        int[] firstArr = new int[arr1.Length];
        int[] secondArr = new int[arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
            firstArr[i] = int.Parse(arr1[i]);

        for (int i = 0; i < arr2.Length; i++)
            secondArr[i] = int.Parse(arr2[i]);

        int sumArrayLength = Math.Max(arr1.Length, arr2.Length);
        int[] sumArray = new int[sumArrayLength];

        for (int i = 0; i < sumArray.Length; i++)
            sumArray[i] = firstArr[i % arr1.Length] + secondArr[i % arr2.Length];

        Console.WriteLine(string.Join(" ", sumArray));
    }

}