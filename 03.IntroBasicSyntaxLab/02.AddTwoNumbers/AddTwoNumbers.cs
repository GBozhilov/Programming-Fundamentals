using System;

public class AddTwoNumbers
{
    public static void Main()
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());

        var sum = firstNum + secondNum;

        Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, sum);
    }
}