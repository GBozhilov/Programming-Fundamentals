using System;
using System.Linq;
using System.Text;

public class CompareCharArrays
{
    public static void Main()
    {
        var firstArray = Console.ReadLine()
            .ToCharArray()
            .Where(s => s != ' ')
            .ToArray();
        var secondArray = Console.ReadLine()
            .ToCharArray()
            .Where(s => s != ' ')
            .ToArray();

        var smallLength = Math.Min(firstArray.Length, secondArray.Length);
        var result = new StringBuilder();

        for (int i = 0; i < smallLength; i++)
        {
            var firstChar = firstArray[i];
            var secondChar = secondArray[i];

            if (firstChar.Equals(secondChar))
            {
                continue;
            }

            if (firstChar < secondChar)
            {
                result.AppendLine(string.Join("", firstArray));
                result.Append(string.Join("", secondArray));

                break;
            }

            result.AppendLine(string.Join("", secondArray));
            result.Append(string.Join("", firstArray));

            break;
        }

        if (result.ToString() == string.Empty)
        {
            if (firstArray.Length <= secondArray.Length)
            {
                result.AppendLine(string.Join("", firstArray));
                result.Append(string.Join("", secondArray));
            }
            else
            {
                result.AppendLine(string.Join("", secondArray));
                result.Append(string.Join("", firstArray));
            }

            Console.WriteLine(result);

            return;
        }

        Console.WriteLine(result);
    }
}