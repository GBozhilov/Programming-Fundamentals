using System;

public class BeverageLabels
{
    public static void Main()
    {
        var productName = Console.ReadLine();
        var volume = int.Parse(Console.ReadLine());
        var energyContent = int.Parse(Console.ReadLine());
        var sugarContent = int.Parse(Console.ReadLine());

        var totalEnergy = volume * energyContent / 100.0;
        var totalSugar = volume * sugarContent / 100.0;

        Console.WriteLine($"{volume}ml {productName}:");
        Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
    }
}