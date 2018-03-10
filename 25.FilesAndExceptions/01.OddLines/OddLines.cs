using System.IO;
using System.Linq;

public class OddLines
{
    public static void Main()
    {
        string[] inputLines = File.ReadAllLines("input.txt");
        string[] numberedLines = inputLines
            .Where((line, index) => index % 2 != 0)
            .ToArray();

        File.WriteAllLines("output.txt", numberedLines);
    }
}