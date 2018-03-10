using System.Text;

public class Torso
{
    public int Energy { get; set; }

    public double ProcessorSize { get; set; }

    public string Material { get; set; }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine("#Torso:");
        result.AppendLine($"###Energy consumption: {Energy}");
        result.AppendLine($"###Processor size: {ProcessorSize:F1}");
        result.Append($"###Corpus material: {Material}");

        return result.ToString();
    }
}