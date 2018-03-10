using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationCounter
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();

        Dictionary<string, Dictionary<string, long>> countriesData =
            new Dictionary<string, Dictionary<string, long>>();

        while (!inputLine.Equals("report"))
        {
            string[] tokens = inputLine.Split('|');
            string city = tokens[0];
            string country = tokens[1];
            long population = long.Parse(tokens[2]);

            if (!countriesData.ContainsKey(country))
                countriesData[country] = new Dictionary<string, long>();

            if (!countriesData[country].ContainsKey(city))
                countriesData[country][city] = 0;

            countriesData[country][city] += population;

            inputLine = Console.ReadLine();
        }

        countriesData = countriesData
            .OrderByDescending(x => x.Value.Values.Sum())
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (KeyValuePair<string, Dictionary<string, long>> KVP in countriesData)
        {
            string country = KVP.Key;
            Dictionary<string, long> cityPopulation = KVP.Value
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            long countryPopulation = cityPopulation.Values.Sum();

            Console.WriteLine($"{country} (total population: {countryPopulation})");

            foreach (KeyValuePair<string, long> entry in cityPopulation)
            {
                string city = entry.Key;
                long population = entry.Value;

                Console.WriteLine($"=>{city}: {population}");
            }
        }
    }
}