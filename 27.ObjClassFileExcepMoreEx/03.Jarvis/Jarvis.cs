using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Jarvis
{
    public long Energy { get; set; }

    public Head Head { get; set; }

    public Torso Torso { get; set; }

    public List<Arm> Arms { get; set; }

    public List<Leg> Legs { get; set; }

    public void AddHead(Head headInput)
    {
        if (Head == null)
        {
            Head = headInput;
        }

        if (headInput.Energy < Head.Energy)
        {
            Head = headInput;
        }
    }

    public void AddTorso(Torso torsoInput)
    {
        if (Torso == null)
        {
            Torso = torsoInput;
        }

        if (torsoInput.Energy < Torso.Energy)
        {
            Torso = torsoInput;
        }
    }

    public void AddArm(Arm arm)
    {
        if (Arms == null)
        {
            Arms = new List<Arm>();
        }

        if (Arms.Count < 2)
        {
            Arms.Add(arm);
        }
        else
        {
            for (int i = 0; i < Arms.Count; i++)
            {
                if (Arms[i].Energy > arm.Energy)
                {
                    Arms.RemoveAt(i);
                    Arms.Add(arm);
                }
            }
        }
    }

    public void AddLeg(Leg leg)
    {
        if (Legs == null)
        {
            Legs = new List<Leg>();
        }

        if (Legs.Count < 2)
        {
            Legs.Add(leg);
        }
        else
        {
            for (int i = 0; i < Legs.Count; i++)
            {
                if (Legs[i].Energy > leg.Energy)
                {
                    Legs.RemoveAt(i);
                    Legs.Add(leg);
                }
            }
        }
    }

    public override string ToString()
    {
        if (Head == null || Torso == null || Arms.Count < 2 || Legs.Count < 2)
        {
            return "We need more parts!";
        }

        long totalEnergy = 0;

        totalEnergy += Head.Energy;
        totalEnergy += Torso.Energy;
        totalEnergy += Arms.Sum(a => long.Parse(a.Energy.ToString()));
        totalEnergy += Legs.Sum(l => long.Parse(l.Energy.ToString()));

        if (totalEnergy > Energy)
        {
            return "We need more power!";
        }

        var sb = new StringBuilder();

        sb.AppendLine("Jarvis:");
        sb.AppendLine(Head.ToString());
        sb.AppendLine(Torso.ToString());

        foreach (var arm in Arms.OrderBy(a => a.Energy))
        {
            sb.AppendLine(arm.ToString());
        }

        foreach (var leg in Legs.OrderBy(l => l.Energy))
        {
            sb.AppendLine(leg.ToString());
        }

        return sb.ToString();
    }
}