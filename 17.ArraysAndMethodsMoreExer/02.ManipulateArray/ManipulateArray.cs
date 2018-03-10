using System;
using System.Linq;

public class ManipulateArray
{
    public static void Main()
    {
        var array = Console.ReadLine().Split(' ');
        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var tokens = Console.ReadLine()
                .Split(' ');
            var command = tokens[0];

            switch (command)
            {
                case "Reverse":
                    //Array.Reverse(array);
                    ReverseArray(array);
                    break;
                case "Distinct":
                    array = array
                        .Distinct()
                        .ToArray();
                    break;
                case "Replace":
                    var index = int.Parse(tokens[1]);
                    var newElement = tokens[2];
                    array[index] = newElement;
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", array));
    }

    public static void ReverseArray(string[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            var temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }
    }
}