using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationCounter
{
    public static void Main()
    {
        var countriesData = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("report"))
            {
                break;
            }

            var tokens = inputLine.Split('|');

            var city = tokens[0];
            var country = tokens[1];
            var cityPopulation = int.Parse(tokens[2]);

            if (!countriesData.ContainsKey(country))
            {
                countriesData[country] = new Dictionary<string, long>();
            }

            if (!countriesData[country].ContainsKey(city))
            {
                countriesData[country][city] = 0;
            }

            countriesData[country][city] += cityPopulation;
        }

        countriesData = countriesData
            .OrderByDescending(x => x.Value.Values.Sum())
            .ToDictionary(x => x.Key, y => y.Value);

        foreach (var countryEntry in countriesData)
        {
            var country = countryEntry.Key;
            var citiesAndPopulations = countryEntry.Value
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            var countryPopulation = citiesAndPopulations.Values.Sum();

            Console.WriteLine($"{country} (total population: {countryPopulation})");


            foreach (var cityEntry in citiesAndPopulations)
            {
                var city = cityEntry.Key;
                var cityPopulation = cityEntry.Value;

                Console.WriteLine($"=>{city}: {cityPopulation}");
            }
        }
    }
}