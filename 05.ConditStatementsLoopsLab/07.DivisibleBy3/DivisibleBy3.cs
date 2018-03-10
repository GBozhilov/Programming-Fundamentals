using System;

public class DivisibleBy3
{
    public static void Main()
    {
        for (int i = 3; i <= 99; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}