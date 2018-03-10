using System.Text;

public class Leg
{
    public int Energy { get; set; }

    public int Strength { get; set; }

    public int Speed { get; set; }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine("#Leg:");
        result.AppendLine($"###Energy consumption: {Energy}");
        result.AppendLine($"###Strength: {Strength}");
        result.Append($"###Speed: {Speed}");

        return result.ToString();
    }
}