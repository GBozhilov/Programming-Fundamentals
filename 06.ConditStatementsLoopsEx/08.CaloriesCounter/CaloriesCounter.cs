using System;

public class CaloriesCounter
{
    public static void Main()
    {
        var productsCount = int.Parse(Console.ReadLine());

        var calories = 0;

        for (int i = 0; i < productsCount; i++)
        {
            var currentProduct = Console.ReadLine().ToLower();

            switch (currentProduct)
            {
                case "cheese":
                    calories += 500;
                    break;
                case "tomato sauce":
                    calories += 150;
                    break;
                case "salami":
                    calories += 600;
                    break;
                case "pepper":
                    calories += 50;
                    break;
            }
        }

        Console.WriteLine($"Total calories: {calories}");
    }
}