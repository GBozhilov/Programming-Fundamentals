using System;
using System.Collections.Generic;
using System.Linq;

public class VehicleCatalogue
{
    public static void Main()
    {
        var vehicles = new List<Vehicle>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("End"))
            {
                break;
            }

            var vehicleParams = inputLine.Split(' ');

            var typeOfVehicle = vehicleParams[0].ToLower();
            var modelOfVehicle = vehicleParams[1];
            var colourOfVehicle = vehicleParams[2];
            var horsepowersOfVehicle = int.Parse(vehicleParams[3]);

            var newVehicle = new Vehicle()
            {
                Type = typeOfVehicle == "car" ? "Car" : "Truck",
                Model = modelOfVehicle,
                Colour = colourOfVehicle,
                Horsepower = horsepowersOfVehicle
            };

            vehicles.Add(newVehicle);
        }

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("Close the Catalogue"))
            {
                break;
            }

            var model = inputLine;

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Model == model)
                {
                    Console.WriteLine($"Type: {vehicle.Type}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Colour}");
                    Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    break;
                }
            }
        }

        double carsAverageHorsepower, trucksAverageHorsepower;
        CheckResult(vehicles, out carsAverageHorsepower, out trucksAverageHorsepower);

        Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsepower:F2}.");
        Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsepower:F2}.");
    }

    public static void CheckResult(List<Vehicle> vehicles, out double carsAverageHorsepower, out double trucksAverageHorsepower)
    {
        carsAverageHorsepower = 0.0;
        trucksAverageHorsepower = 0.0;

        try
        {
            carsAverageHorsepower = vehicles
                .Where(v => v.Type == "Car")
                .Select(v => v.Horsepower)
                .Average();
        }
        catch (Exception)
        {
            carsAverageHorsepower = 0;
        }

        try
        {
            trucksAverageHorsepower = vehicles
                .Where(v => v.Type == "Truck")
                .Select(v => v.Horsepower)
                .Average();
        }
        catch (Exception)
        {
            trucksAverageHorsepower = 0;
        }
    }
}

public class Vehicle
{
    public string Type { get; set; }

    public string Model { get; set; }

    public string Colour { get; set; }

    public int Horsepower { get; set; }
}