using System;

public class CharacterStats
{
    public static void Main()
    {
        var name = Console.ReadLine();
        var currentHealth = int.Parse(Console.ReadLine());
        var maxHealth = int.Parse(Console.ReadLine());
        var currentEnergy = int.Parse(Console.ReadLine());
        var maxEnergy = int.Parse(Console.ReadLine());

        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Health: |"
            + new string('|', currentHealth)
            + new string('.', maxHealth - currentHealth)
            + "|");
        Console.WriteLine("Energy: |"
            + new string('|', currentEnergy)
            + new string('.', maxEnergy - currentEnergy)
            + "|");
    }
}