using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double oldPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double newPrice = double.Parse(Console.ReadLine());

            double difference = GetDifference(oldPrice, newPrice);
            bool hasSignificantDifference = IsEnoughDiff(difference, threshold);

            string message = GetMessage(newPrice, oldPrice, difference, hasSignificantDifference);

            Console.WriteLine(message);

            oldPrice = newPrice;
        }
    }

    public static string GetMessage(double newPrice, double oldPrice, double difference, bool hasSignificantDifference)
    {
        string resultMessage = string.Empty;
        double percentage = difference * 100;

        if (difference == 0)
        {
            resultMessage = string.Format("NO CHANGE: {0}", newPrice);
        }
        else if (!hasSignificantDifference)
        {
            resultMessage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)",
                oldPrice, newPrice, percentage);
        }
        else if (hasSignificantDifference && difference > 0)
        {
            resultMessage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)",
                oldPrice, newPrice, percentage);
        }
        else if (hasSignificantDifference && difference < 0)
        {
            resultMessage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)",
                oldPrice, newPrice, percentage);
        }

        return resultMessage;
    }

    public static bool IsEnoughDiff(double difference, double threshold)
    {
        if (Math.Abs(difference) >= threshold)
        {
            return true;
        }

        return false;
    }

    public static double GetDifference(double oldPrice, double newPrice)
    {
        double difference = (newPrice - oldPrice) / oldPrice;

        return difference;
    }
}
