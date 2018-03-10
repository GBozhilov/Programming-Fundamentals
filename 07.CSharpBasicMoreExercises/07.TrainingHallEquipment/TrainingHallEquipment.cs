using System;
using System.Text;

public class TrainingHallEquipment
{
    public static void Main()
    {
        var budget = double.Parse(Console.ReadLine());
        var itemsCount = int.Parse(Console.ReadLine());

        var subtotal = 0.0;

        for (int i = 0; i < itemsCount; i++)
        {
            var name = Console.ReadLine();
            var price = double.Parse(Console.ReadLine());
            var quantity = int.Parse(Console.ReadLine());

            if (quantity > 1)
            {
                name = GetNameInPlural(name);
            }

            var currentPurchase = quantity * price;
            subtotal += currentPurchase;

            Console.WriteLine($"Adding {quantity} {name} to cart.");
        }

        Console.WriteLine($"Subtotal: ${subtotal:F2}");

        var enoughMoney = budget >= subtotal;
        var moneyLeft = budget - subtotal;
        var insufficientMoney = Math.Abs(moneyLeft);

        if (enoughMoney)
        {
            Console.WriteLine($"Money left: ${moneyLeft:F2}");
        }
        else
        {
            Console.WriteLine($"Not enough. We need ${insufficientMoney:F2} more.");
        }
    }

    public static string GetNameInPlural(string name)
    {
        var nameInPlural = new StringBuilder();

        if (name.EndsWith("y"))
        {
            nameInPlural.Append(name.Remove(name.Length - 1) + "ies");
        }
        else if (name.EndsWith("ch") || name.EndsWith("sh") || name.EndsWith("o") || name.EndsWith("s") || name.EndsWith("x") || name.EndsWith("z"))
        {
            nameInPlural.Append(name + "es");
        }
        else
        {
            nameInPlural.Append(name + "s");
        }

        return nameInPlural.ToString();
    }
}