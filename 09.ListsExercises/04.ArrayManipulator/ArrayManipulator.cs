using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayManipulator
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string command = Console.ReadLine();

        while (command != "print")
        {
            List<string> commandList = command.Split().ToList();

            if (commandList[0] == "add")
            {
                int index = int.Parse(commandList[1]);
                int element = int.Parse(commandList[2]);
                numbers.Insert(index, element);
            }
            else if (commandList[0] == "addMany")
            {
                int index = int.Parse(commandList[1]);
                List<int> numsToAdd = new List<int>();

                for (int i = 2; i < commandList.Count; i++)
                    numsToAdd.Add(int.Parse(commandList[i]));

                numbers.InsertRange(index, numsToAdd);
            }
            else if (commandList[0] == "contains")
            {
                int element = int.Parse(commandList[1]);

                Console.WriteLine(numbers.IndexOf(element));
            }
            else if (commandList[0] == "remove")
            {
                int index = int.Parse(commandList[1]);
                numbers.RemoveAt(index);
            }
            else if (commandList[0] == "shift")
            {
                int positions = int.Parse(commandList[1]);

                for (int i = 0; i < positions; i++)
                {
                    int temp = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(temp);
                }
            }
            else if (commandList[0] == "sumPairs")
                numbers = SumPairs(numbers);

            command = Console.ReadLine();
        }

        Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }

    static List<int> SumPairs(List<int> numbers)
    {
        List<int> temp = new List<int>();

        for (int i = 0; i < numbers.Count - 1; i += 2)
            temp.Add(numbers[i] + numbers[i + 1]);

        if (numbers.Count % 2 != 0)
            temp.Add(numbers[numbers.Count - 1]);

        return temp;
    }
}