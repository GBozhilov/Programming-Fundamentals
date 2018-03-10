using System;

public class ChooseDrink
{
    public static void Main()
    {
        var profession = Console.ReadLine();
        var quantity = int.Parse(Console.ReadLine());

        var singlePrice = 0.0;

        switch (profession)
        {
            case "Athlete":
                singlePrice = 0.70;
                break;
            case "Businessman":
            case "Businesswoman":
                singlePrice = 1.00;
                break;
            case "SoftUni Student":
                singlePrice = 1.70;
                break;
            default:
                singlePrice = 1.20;
                break;
        }

        var totalPrice = quantity * singlePrice;

        Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
    }
}