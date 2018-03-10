using System;

public class CakeIngredients
{
    public static void Main()
    {
        var count = 0;

        while (true)
        {
            var ingredient = Console.ReadLine();

            if (ingredient == "Bake!")
            {
                Console.WriteLine($"Preparing cake with {count} ingredients.");
                break;
            }

            Console.WriteLine($"Adding ingredient {ingredient}.");
            count++;
        }
    }
}