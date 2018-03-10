using System;
using System.Linq;

public class InventoryMatcher
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
            var currentProduct = Console.ReadLine();

            if (currentProduct == "done")
            {
                break;
            }

            var index = Array.IndexOf(names, currentProduct);
            var price = prices[index];
            var quantity = quantities[index];

            Console.WriteLine($"{currentProduct} costs: {price}; Available quantity: {quantity}");
        }
    }
}