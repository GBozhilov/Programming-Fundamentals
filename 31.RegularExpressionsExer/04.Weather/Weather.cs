using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Weather
{
    public static void Main()
    {
        var weatherInfoByCity = new Dictionary<string, WeatherInfo>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("end")) break;

            var pattern = @"(?<city>[A-Z]{2})(?<temperature>\d+\.\d+)(?<type>[A-Za-z]+)\|";
            var match = Regex.Match(inputLine, pattern);

            if (!match.Success) continue;

            var nameOfCity = match.Groups["city"].Value;
            var averageTemperature = decimal.Parse(match.Groups["temperature"].Value);
            var weatherType = match.Groups["type"].Value;

            var newWeatherInfo = new WeatherInfo()
            {
                AverageTemperature = averageTemperature,
                WeatherType = weatherType
            };

            weatherInfoByCity[nameOfCity] = newWeatherInfo;
        }

        foreach (var city in weatherInfoByCity.OrderBy(a => a.Value.AverageTemperature))
        {
            var nameOfCity = city.Key;
            var averageTemperature = city.Value.AverageTemperature;
            var weatherType = city.Value.WeatherType;

            Console.WriteLine($"{nameOfCity} => {averageTemperature:F2} => {weatherType}");
        }
    }
}

public class WeatherInfo
{
    public decimal AverageTemperature { get; set; }

    public string WeatherType { get; set; }
}