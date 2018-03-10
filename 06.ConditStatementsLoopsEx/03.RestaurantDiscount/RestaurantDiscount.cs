using System;

public class RestaurantDiscount
{
    public static void Main()
    {
        var groupSize = int.Parse(Console.ReadLine());
        var package = Console.ReadLine(); ;

        var hall = string.Empty;
        var hallPrice = 0;

        if (groupSize >= 1 && groupSize <= 50)
        {
            hall = "Small Hall";
            hallPrice = 2500;
        }
        else if (groupSize >= 51 && groupSize <= 100)
        {
            hall = "Terrace";
            hallPrice = 5000;
        }
        else if (groupSize >= 100 && groupSize <= 120)
        {
            hall = "Great Hall";
            hallPrice = 7500;
        }

        var packagePrice = 0;
        var discount = 0.0;

        switch (package)
        {
            case "Normal":
                packagePrice = 500;
                discount = 0.05;
                break;
            case "Gold":
                packagePrice = 750;
                discount = 0.10;
                break;
            case "Platinum":
                packagePrice = 1000;
                discount = 0.15;
                break;
        }

        var totalPrice = hallPrice + packagePrice - discount * (hallPrice + packagePrice);
        var singlePrice = totalPrice / groupSize;

        if (hall != string.Empty)
        {
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {singlePrice:F2}$");
        }
        else
        {
            Console.WriteLine($"We do not have an appropriate hall.");
        }
    }
}