using System;

public class MathPower
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        double raisedNumber = RaiseToPower(number, power);

        Console.WriteLine(raisedNumber);
    }

    static double RaiseToPower(double number, int power)
    {
        double result = Math.Pow(number, power);
        return result;
    }
}