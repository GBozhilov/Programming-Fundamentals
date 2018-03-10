using System;

public class ComparingFloats
{
    public static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());

        bool areEqual = true;
        const double epsilon = 0.000001;
        double difference = Math.Abs(firstNum - secondNum);

        if (difference >= epsilon)
            areEqual = false;

        Console.WriteLine(areEqual);
    }
}