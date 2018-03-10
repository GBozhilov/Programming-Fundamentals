using System;

public class FastPrimeChecker
{
    public static void Main()
    {
        var end = int.Parse(Console.ReadLine());

        for (int currentNum = 2; currentNum <= end; currentNum++)
        {
            var isPrime = true;

            for (int divisor = 2; divisor <= Math.Sqrt(currentNum); divisor++)
            {
                if (currentNum % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine($"{currentNum} -> {isPrime}");
        }
    }
}