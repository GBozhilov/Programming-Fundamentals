using System;
using System.Collections.Generic;

public class PizzaIngredients
{
    public static void Main()
    {
        var ingredients = Console.ReadLine()
            .Split(' ');
        var searchedLength = int.Parse(Console.ReadLine());

        var addedIngredients = new List<string>();
        var count = 0;

        foreach (var ingredient in ingredients)
        {
            if (ingredient.Length == searchedLength)
            {
                addedIngredients.Add(ingredient);
                count++;

                Console.WriteLine($"Adding {ingredient}.");
            }

            if (count >= 10)
            {
                break;
            }
        }

        Console.WriteLine($"Made pizza with total of {count} ingredients.");
        Console.WriteLine($"The ingredients are: {string.Join(", ", addedIngredients)}.");
    }
}