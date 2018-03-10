using System;

public class DebitCardNumber
{
    public static void Main()
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());
        var thirdNum = int.Parse(Console.ReadLine());
        var fourthNum = int.Parse(Console.ReadLine());

        var debitCardNum = $"{firstNum:D4} {secondNum:D4} {thirdNum:D4} {fourthNum:D4}";

        Console.WriteLine(debitCardNum);
    }
}