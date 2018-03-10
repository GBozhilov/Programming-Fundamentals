using System;
using System.Globalization;

public class SoftuniCoffeeOrders
{
    public static void Main()
    {
        var ordersCount = int.Parse(Console.ReadLine());

        decimal totalPrice = 0;

        for (int i = 0; i < ordersCount; i++)
        {
            var PricePerCapsule = decimal.Parse(Console.ReadLine());
            var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",
                CultureInfo.InvariantCulture);
            var capsulesCount = int.Parse(Console.ReadLine());

            var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
            var currentOrder = (decimal)daysInMonth * capsulesCount * PricePerCapsule;

            totalPrice += currentOrder;

            Console.WriteLine($"The price for the coffee is: ${currentOrder:F2}");
        }

        Console.WriteLine($"Total: ${totalPrice:F2}");
    }
}