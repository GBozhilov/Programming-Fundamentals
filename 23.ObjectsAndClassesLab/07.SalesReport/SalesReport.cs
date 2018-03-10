using System;
using System.Collections.Generic;

public class SalesReport
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedDictionary<string, decimal> salesByTown =
            new SortedDictionary<string, decimal>();

        for (int i = 0; i < n; i++)
        {
            Sale currentSale = Sale.Parse(Console.ReadLine());
            //Sale currentSale = ReadSale();

            string town = currentSale.Town;
            decimal sales = currentSale.Quantity * currentSale.Price;

            if (!salesByTown.ContainsKey(town))
            {
                salesByTown[town] = 0;
            }

            salesByTown[town] += sales;
        }

        PrintResult(salesByTown);
    }

    public static void PrintResult(SortedDictionary<string, decimal> salesByTown)
    {
        foreach (KeyValuePair<string, decimal> townSalesPair in salesByTown)
        {
            string town = townSalesPair.Key;
            decimal sales = townSalesPair.Value;

            Console.WriteLine($"{town} -> {sales:F2}");
        }
    }

    public static Sale ReadSale()
    {
        string[] saleInfo = Console.ReadLine()
            .Split(' ');

        Sale newSale = new Sale()
        {
            Town = saleInfo[0],
            Product = saleInfo[1],
            Price = decimal.Parse(saleInfo[2]),
            Quantity = decimal.Parse(saleInfo[3])
        };

        return newSale;
    }
}

public class Sale
{
    public string Town { get; set; }

    public string Product { get; set; }

    public decimal Price { get; set; }

    public decimal Quantity { get; set; }

    public static Sale Parse(string saleAsString)
    {
        string[] saleInfo = saleAsString.Split(' ');

        return new Sale
        {
            Town = saleInfo[0],
            Product = saleInfo[1],
            Price = decimal.Parse(saleInfo[2]),
            Quantity = decimal.Parse(saleInfo[3])
        };
    }
}