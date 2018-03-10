using System;

public class BoatSimulator
{
    public static void Main()
    {
        var firstBoat = Console.ReadLine()[0];
        var secondBoat = Console.ReadLine()[0];
        var n = int.Parse(Console.ReadLine());

        var firstBoatMoves = 0;
        var secondBoatMoves = 0;

        for (int i = 1; i <= n; i++)
        {
            var line = Console.ReadLine();

            if (line == "UPGRADE")
            {
                firstBoat += (char)3;
                secondBoat += (char)3;
                continue;
            }

            if (i % 2 != 0)
            {
                firstBoatMoves += line.Length;
            }
            else
            {
                secondBoatMoves += line.Length;
            }

            if (firstBoatMoves >= 50 || secondBoatMoves >= 50)
            {
                break;
            }
        }

        var winner = firstBoatMoves > secondBoatMoves ? firstBoat : secondBoat;

        Console.WriteLine(winner);
    }
}