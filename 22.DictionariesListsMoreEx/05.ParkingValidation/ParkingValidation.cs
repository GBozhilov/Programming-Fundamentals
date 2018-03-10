using System;
using System.Collections.Generic;
using System.Linq;

public class ParkingValidation
{
    public static void Main()
    {
        var usersLicenses = new Dictionary<string, string>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var parkingParams = Console.ReadLine()
                .Split(' ');

            var command = parkingParams[0];
            var username = parkingParams[1];

            if (command.Equals("register"))
            {
                var licensePlateNumber = parkingParams[2];

                if (usersLicenses.ContainsValue(licensePlateNumber))
                {
                    Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                    continue;
                }

                if (usersLicenses.ContainsKey(username) && (usersLicenses[username] != licensePlateNumber))
                {
                    var existingNumber = usersLicenses[username];

                    Console.WriteLine($"ERROR: already registered with plate number {existingNumber}");
                    continue; ;
                }

                if (!IsLicencePlateValid(licensePlateNumber))
                {
                    Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                    continue;
                }

                usersLicenses[username] = licensePlateNumber;

                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
            }
            else //if (command.Equals("unregister"))
            {
                if (!usersLicenses.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                    continue;
                }

                usersLicenses.Remove(username);

                Console.WriteLine($"user {username} unregistered successfully");
            }
        }

        PrintResult(usersLicenses);
    }

    public static void PrintResult(Dictionary<string, string> usersLicenses)
    {
        foreach (var userNumberPair in usersLicenses)
        {
            var username = userNumberPair.Key;
            var licensePlateNumber = userNumberPair.Value;

            Console.WriteLine($"{username} => {licensePlateNumber}");
        }
    }

    public static bool CheckLicensePlateNumber(string licensePlateNumber)
    {
        if (licensePlateNumber.Length != 8)
        {
            return false;
        }

        var leftAndRightPart = licensePlateNumber.Remove(2, 4);

        for (int i = 0; i < leftAndRightPart.Length; i++)
        {
            var currentSymbol = leftAndRightPart[i];

            if (!(char.IsLetter(currentSymbol) && char.IsUpper(currentSymbol)))
            {
                return false;
            }
        }

        var middlePart = licensePlateNumber.Substring(2, 4);
        var number = 0;

        if (!int.TryParse(middlePart, out number))
        {
            return false;
        }

        return true;
    }

    public static bool IsLicencePlateValid(string licensePlateNumber)
    {
        if (licensePlateNumber.Length == 8
            && licensePlateNumber.Take(2).All(char.IsUpper)
            && licensePlateNumber.Skip(2).Take(4).All(char.IsDigit)
            && licensePlateNumber.Skip(6).All(char.IsUpper))
        {
            return true;
        }

        return false;
    }
}