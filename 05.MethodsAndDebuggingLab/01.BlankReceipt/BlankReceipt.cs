using System;

public class BlankReceipt
{
    public static void Main()
    {
        PrintReceipt();
    }

    static void PrintReceipt()
    {
        PrintReceiptHeader();
        PrintReceiptBody();
        PrintReceiptFooter();
    }

    static void PrintReceiptHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }

    static void PrintReceiptBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    static void PrintReceiptFooter()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine(@"© SoftUni");
    }
}