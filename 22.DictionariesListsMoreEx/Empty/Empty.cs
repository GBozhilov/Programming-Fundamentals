using System;
using System.Linq;

public class ByteFlip
{
    public static void Main()
    {
        Console.ReadLine()
            .Split(' ')
            .Where(x => x.Length == 2)
            .Select(x => x.Reverse())
            .Select(x => string.Join("", x))
            .Reverse()
            .Select(x => Convert.ToInt32(x, 16))
            .ToList()
            .ForEach(x => Console.Write((char)x));

        Console.WriteLine();
    }
}