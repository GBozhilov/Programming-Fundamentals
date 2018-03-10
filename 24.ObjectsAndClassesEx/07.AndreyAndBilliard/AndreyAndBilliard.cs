using System;
using System.Collections.Generic;
using System.Linq;

public class AndreyAndBilliard
{
    public static void Main()
    {
        var productsPrices = new Dictionary<string, decimal>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var currentProduct = Console.ReadLine().Split('-');

            var product = currentProduct.First();
            var price = decimal.Parse(currentProduct.Last());

            productsPrices[product] = price;
        }

        List<Customer> customers = new List<Customer>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("end of clients"))
            {
                break;
            }

            var clientParams = inputLine.Split(new char[] { '-', ',' },
                StringSplitOptions.RemoveEmptyEntries);

            var clientName = clientParams[0];
            var desiredProduct = clientParams[1];
            var quantity = int.Parse(clientParams[2]);

            if (!productsPrices.ContainsKey(desiredProduct))
            {
                continue;
            }

            var customer = new Customer()
            {
                Name = clientName,
                ShopList = new Dictionary<string, int>()
                {
                    { desiredProduct, quantity}
                },
                Bill = quantity * productsPrices[desiredProduct]
            };

            if (!customers.Exists(c => c.Name == clientName))
            {
                customers.Add(customer);

                continue;
            }

            var existingCustomer = customers.First(c => c.Name == clientName);

            if (!(existingCustomer.ShopList.ContainsKey(desiredProduct)))
            {
                existingCustomer.ShopList[desiredProduct] = quantity;
            }
            else
            {
                existingCustomer.ShopList[desiredProduct] += quantity;
            }

            existingCustomer.Bill += customer.Bill;
        }

        foreach (var customer in customers.OrderBy(c => c.Name))
        {
            Console.WriteLine(customer.Name);

            foreach (var entry in customer.ShopList)
            {
                var product = entry.Key;
                var quantity = entry.Value;

                Console.WriteLine($"-- {product} - {quantity}");
            }

            var bill = customer.Bill;

            Console.WriteLine($"Bill: {bill:F2}");
        }

        var totalBill = customers.Sum(c => c.Bill);

        Console.WriteLine($"Total bill: {totalBill:F2}");
    }
}

public class Customer
{
    public string Name { get; set; }

    public Dictionary<string, int> ShopList { get; set; }

    public decimal Bill { get; set; }
}