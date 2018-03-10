using System;

public class SweetDessert
{
    public static void Main()
    {
        var cashAmount = decimal.Parse(Console.ReadLine());
        var guestsCount = int.Parse(Console.ReadLine());
        var bananaPrice = decimal.Parse(Console.ReadLine());
        var eggPrice = decimal.Parse(Console.ReadLine());
        var berriesPrice = decimal.Parse(Console.ReadLine());

        var neededSets = Math.Ceiling(guestsCount / 6M);
        var setPrice = 2 * bananaPrice + 4 * eggPrice + 0.2M * berriesPrice;
        var totalPrice = neededSets * setPrice;
        var hasEnoughMoney = cashAmount - totalPrice >= 0;
        var shortage = totalPrice - cashAmount;

        if (hasEnoughMoney)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {shortage:F2}lv more.");
        }
    }
}