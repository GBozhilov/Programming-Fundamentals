using System;

public class MathPowerIterations
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        double raisedNumber = GetRaisedToPower(number, power);

        Console.WriteLine(raisedNumber);
    }

    static double GetRaisedToPower(double number, int power)
    {
        double result = 1;

        for (int cnt = 0; cnt < power; cnt++)
        {
            result *= number;
        }

        return result;
    }
}