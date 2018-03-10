using System;

public class NeighbourWars
{
    public static void Main()
    {
        var peshoDamage = int.Parse(Console.ReadLine());
        var goshoDamage = int.Parse(Console.ReadLine());

        var peshoHealth = 100;
        var goshoHealth = 100;
        var rounds = 1;

        while (true)
        {
            if (rounds % 2 != 0)
            {
                goshoHealth -= peshoDamage;

                if (goshoHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {rounds}th round.");
                    break;
                }

                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
            }
            else
            {
                peshoHealth -= goshoDamage;

                if (peshoHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {rounds}th round.");
                    break;
                }

                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
            }

            if (rounds % 3 == 0)
            {
                peshoHealth += 10;
                goshoHealth += 10;
            }

            rounds++;
        }
    }
}