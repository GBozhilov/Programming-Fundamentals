using System;
using System.Linq;

public class UpgradedMatcher
{
    public static void Main()
    {
        var names = Console.ReadLine()
            .Split(' ');
        var quantities = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();
        var prices = Console.ReadLine()
            .Split(' ')
            .Select(decimal.Parse)
            .ToArray();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine == "done")
            {
                break;
            }

            var tokens = inputLine
                .Split(' ');

            var productForOrder = tokens[0];
            var quantityForOrder = long.Parse(tokens[1]);

            var index = Array.IndexOf(names, productForOrder);
            var price = prices[index];
            var availableQuantity = GetQuantity(quantities, index);

            if (quantityForOrder > availableQuantity)
            {
                Console.WriteLine($"We do not have enough {productForOrder}");

                continue;
            }

            var totalOrderPrice = quantityForOrder * price;

            Console.WriteLine($"{productForOrder} x {quantityForOrder} costs {totalOrderPrice:F2}");

            if (index < quantities.Length)
            {
                quantities[index] -= quantityForOrder;
            }
        }
    }

    public static long GetQuantity(long[] quantities, int index)
    {
        if (index >= quantities.Length)
        {
            return 0;
        }

        return quantities[index];
    }
}