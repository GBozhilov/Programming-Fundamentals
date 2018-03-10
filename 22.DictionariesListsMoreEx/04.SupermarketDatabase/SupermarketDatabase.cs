using System;
using System.Collections.Generic;
using System.Linq;

public class SupermarketDatabase
{
    public static void Main()
    {
        var productsInfo = new Dictionary<string, double[]>();

        var inputLine = Console.ReadLine();

        while (!inputLine.Equals("stocked"))
        {
            var tokens = inputLine.Split(' ');

            var product = tokens[0];
            var price = double.Parse(tokens[1]);
            var quantity = int.Parse(tokens[2]);

            if (!productsInfo.ContainsKey(product))
            {
                productsInfo[product] = new double[3];
            }

            productsInfo[product][0] = price;
            productsInfo[product][1] += quantity;

            var newQuantity = productsInfo[product][1];
            var newTotalPrice = newQuantity * price;

            productsInfo[product][2] = newTotalPrice;

            inputLine = Console.ReadLine();
        }

        PrintResult(productsInfo);
    }

    public static void PrintResult(Dictionary<string, double[]> productsInfo)
    {
        foreach (var productInfoPair in productsInfo)
        {
            var product = productInfoPair.Key;
            var productData = productInfoPair.Value;
            var price = productData[0];
            var quantity = productData[1];
            var totalPrice = productData[2];

            Console.WriteLine($"{product}: ${price:F2} * {quantity} = ${totalPrice:F2}");
        }

        var grandTotal = productsInfo.Values.Sum(a => a[2]);

        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${grandTotal:F2}");
    }
}