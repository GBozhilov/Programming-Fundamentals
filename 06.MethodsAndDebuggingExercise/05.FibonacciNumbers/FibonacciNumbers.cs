using System;

public class FibonacciNumbers
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var fibNum = Fib(n);

        Console.WriteLine(fibNum);
    }

    public static long Fib(int n)
    {
        var a = 0;
        var b = 1;

        for (int i = 0; i < n; i++)
        {
            var temp = a;
            a = b;
            b = temp + b;
        }

        return b;
    }
}