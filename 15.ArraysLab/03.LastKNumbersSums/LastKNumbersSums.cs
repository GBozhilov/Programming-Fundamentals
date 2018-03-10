using System;

public class LastKNumbersSums
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var k = int.Parse(Console.ReadLine());

        var array = new long[n];
        array[0] = 1;

        for (int i = 1; i < array.Length; i++)
        {
            var pos = i - 1;

            while (pos >= 0 && pos >= i - k)
            {
                array[i] += array[pos];
                pos--;
            }
        }

        Console.WriteLine(string.Join(" ", array));
    }
}