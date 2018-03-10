using System;

public class SpecialNumbersOtherWay
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int currentNumber = 1; currentNumber <= n; currentNumber++)
        {
            int sum = 0;
            string currentNumberStr = currentNumber.ToString();

            for (int i = 0; i < currentNumberStr.Length; i++)
            {
                sum += int.Parse(currentNumberStr[i].ToString());
            }

            bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

            Console.WriteLine($"{currentNumber} -> {isSpecial}");
        }
    }
}