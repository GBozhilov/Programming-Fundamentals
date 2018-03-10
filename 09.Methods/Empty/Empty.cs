using System;

public class Empty
{
    public static void Main()
    {
        PrintTotalAmountForBooks(3m, 2.5m);
        PrintTotalAmountForBooks(1m, 2m, 3.5m, 7.5m);
    }

    static long CalcSum(params int[] elements)
    {
        long sum = 0;
        foreach (int element in elements)
        {
            sum += element;
        }
        return sum;
    }

    static void PrintTotalAmountForBooks(params decimal[] prices)
    {
        decimal totalAmount = 0;

        foreach (decimal singleBookPrice in prices)
        {
            totalAmount += singleBookPrice;
        }
        Console.WriteLine("The total amount of all books is: " +
            totalAmount);
    }

}