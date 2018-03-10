using System.Text;

public class Arm
{
    public int Energy { get; set; }

    public int Reach { get; set; }

    public int Fingers { get; set; }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine("#Arm:");
        result.AppendLine($"###Energy consumption: {Energy}");
        result.AppendLine($"###Reach: {Reach}");
        result.Append($"###Fingers: {Fingers}");

        return result.ToString();
    }
}