using System;

public class Program
{
    public static void Main()
    {
        var robotEnergy = long.Parse(Console.ReadLine());

        var jarvis = new Jarvis();
        jarvis.Energy = robotEnergy;

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("Assemble!")) break;

            var tokens = inputLine.Split(' ');

            var bodyPart = tokens[0];

            switch (bodyPart)
            {
                case "Head":
                    var head = new Head()
                    {
                        Energy = int.Parse(tokens[1]),
                        Iq = int.Parse(tokens[2]),
                        Material = tokens[3]
                    };
                    jarvis.AddHead(head);
                    break;
                case "Torso":
                    var torso = new Torso()
                    {
                        Energy = int.Parse(tokens[1]),
                        ProcessorSize = double.Parse(tokens[2]),
                        Material = tokens[3]
                    };
                    jarvis.AddTorso(torso);
                    break;
                case "Leg":
                    var leg = new Leg()
                    {
                        Energy = int.Parse(tokens[1]),
                        Strength = int.Parse(tokens[2]),
                        Speed = int.Parse(tokens[3])
                    };
                    jarvis.AddLeg(leg);
                    break;
                case "Arm":
                    var arm = new Arm()
                    {
                        Energy = int.Parse(tokens[1]),
                        Reach = int.Parse(tokens[2]),
                        Fingers = int.Parse(tokens[3])
                    };
                    jarvis.AddArm(arm);
                    break;
            }
        }

        Console.WriteLine(jarvis.ToString());
    }
}