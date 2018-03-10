using System.IO;

public class LineNumbers
{
    public static void Main()
    {
        string[] inputLines = File.ReadAllLines("input.txt");
        string[] outputLines = new string[inputLines.Length];

        for (int i = 0; i < inputLines.Length; i++)
        {
            outputLines[i] = $"{i + 1}. {inputLines[i]}";
        }

        File.WriteAllLines("output.txt", outputLines);
    }
}