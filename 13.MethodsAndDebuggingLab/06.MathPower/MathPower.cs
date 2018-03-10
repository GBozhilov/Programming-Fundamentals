using System;

public class MathPower
{
    public static void Main()
    {
        var number = double.Parse(Console.ReadLine());
        var power = int.Parse(Console.ReadLine());

        var result = RaiseToPower(number, power);

        Console.WriteLine(result);
    }

    public static double RaiseToPower(double number, int power)
    {
        var raisedNum = Math.Pow(number, power);

        return raisedNum;
    }
}