using System;
using System.Linq;
using System.Text;

public class MultiplyBigNumber
{
    public static void Main()
    {
        var firstNum = Console.ReadLine();
        var secondNum = int.Parse(Console.ReadLine());

        if (firstNum == "0" || secondNum == 0 || firstNum == string.Empty)
        {
            Console.WriteLine(0);
            return;
        }

        var sb = new StringBuilder();
        var remainder = 0;

        for (int i = firstNum.Length - 1; i >= 0; i--)
        {
            var currentNum = int.Parse(firstNum[i].ToString());
            var product = currentNum * secondNum + remainder;
            var numToAdd = product % 10;

            sb.Append(numToAdd);
            remainder = product / 10;
        }

        sb.Append(remainder);

        var result = new string(sb.ToString().TrimEnd('0').Reverse().ToArray());

        Console.WriteLine(result);
    }
}