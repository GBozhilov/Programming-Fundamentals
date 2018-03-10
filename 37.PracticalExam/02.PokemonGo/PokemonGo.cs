using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonDon_tGo
{
    public static void Main()
    {
        var allPokemons = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var sumOfRemovedElements = 0;

        while (allPokemons.Any())
        {
            var currentIndex = int.Parse(Console.ReadLine());

            if (currentIndex < 0)
            {
                var lastElement = allPokemons.Last();
                var elementToRemove = allPokemons.First();

                sumOfRemovedElements += elementToRemove;
                allPokemons[0] = lastElement;
                IncOrDecElements(allPokemons, elementToRemove);
            }
            else if (currentIndex >= allPokemons.Count)
            {
                var firstElement = allPokemons.First();
                var elementToRemove = allPokemons.Last();

                sumOfRemovedElements += elementToRemove;
                allPokemons[allPokemons.Count - 1] = firstElement;
                IncOrDecElements(allPokemons, elementToRemove);
            }
            else
            {
                var elementToRemove = allPokemons[currentIndex];

                sumOfRemovedElements += elementToRemove;
                allPokemons.RemoveAt(currentIndex);
                IncOrDecElements(allPokemons, elementToRemove);
            }
        }

        Console.WriteLine(sumOfRemovedElements);
    }

    public static void IncOrDecElements(List<int> allPokemons, int elementToRemove)
    {
        for (int i = 0; i < allPokemons.Count; i++)
        {
            var currentElement = allPokemons[i];

            if (currentElement <= elementToRemove)
            {
                allPokemons[i] += elementToRemove;
            }
            else
            {
                allPokemons[i] -= elementToRemove;
            }
        }
    }
}