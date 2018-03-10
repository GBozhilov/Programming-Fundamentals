using System.Text;

public class Head
{
    public int Energy { get; set; }

    public int Iq { get; set; }

    public string Material { get; set; }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine("#Head:");
        result.AppendLine($"###Energy consumption: {Energy}");
        result.AppendLine($"###IQ: {Iq}");
        result.Append($"###Skin material: {Material}");

        return result.ToString();
    }
}