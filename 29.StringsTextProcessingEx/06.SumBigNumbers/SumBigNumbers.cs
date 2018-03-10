using System;
using System.Linq;
using System.Text;

public class SumBigNumbers
{
    public static void Main()
    {
        var firstNumArr = Console.ReadLine()
            .Reverse()
            .ToArray();
        var secondNumArr = Console.ReadLine()
            .Reverse()
            .ToArray();

        var shorterNumArr = firstNumArr.Length > secondNumArr.Length ? secondNumArr : firstNumArr;
        var longerNumArr = firstNumArr.Length > secondNumArr.Length ? firstNumArr : secondNumArr;

        var remainder = 0;
        var numToAdd = 0;
        var sb = new StringBuilder();

        for (int i = 0; i < shorterNumArr.Length; i++)
        {
            var firstNum = int.Parse(firstNumArr[i].ToString());
            var secondNum = int.Parse(secondNumArr[i].ToString());
            var currentSum = firstNum + secondNum + remainder;

            numToAdd = currentSum % 10;
            sb.Append(numToAdd);
            remainder = currentSum / 10;
        }

        for (int i = shorterNumArr.Length; i < longerNumArr.Length; i++)
        {
            var currentNum = int.Parse(longerNumArr[i].ToString()) + remainder;

            numToAdd = currentNum % 10;
            sb.Append(numToAdd);
            remainder = currentNum / 10;
        }

        sb.Append(remainder);

        var result = new string(sb.ToString().TrimEnd('0').Reverse().ToArray());

        Console.WriteLine(result);
    }
}