using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.СръбскоUnleashed
{
    public class СръбскоUnleashed
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> cityProfit =
                new Dictionary<string, Dictionary<string, int>>();

            string[] singerInfo = ReadInfo();

            while (!singerInfo[0].Equals("End"))
            {
                if (!singerInfo[0][singerInfo[0].Length - 1].Equals(' '))
                    singerInfo = ReadInfo();
                else
                {
                    string[] leftPart = singerInfo[0].Split(new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries);
                    string[] rightPart = singerInfo[1].Split(new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries);

                    string singer = string.Join(" ", leftPart);

                    if (rightPart.Length - 2 > 0)
                    {
                        string[] cityAsString = new string[rightPart.Length - 2];

                        for (int i = 0; i < cityAsString.Length; i++)
                            cityAsString[i] = rightPart[i];

                        int ticketPrice = 0;
                        int ticketCount = 0;

                        if (int.TryParse(rightPart[rightPart.Length - 1], out ticketCount)
                            && int.TryParse(rightPart[rightPart.Length - 2], out ticketPrice))
                        {
                            int profit = ticketPrice * ticketCount;
                            string city = string.Join(" ", cityAsString);
                            InsertCity(cityProfit, city);
                            InsertProfit(cityProfit, city, singer, profit);
                            singerInfo = ReadInfo();
                        }
                        else
                            singerInfo = ReadInfo();
                    }
                    else
                        singerInfo = ReadInfo();
                }
            }

            PrintResult(cityProfit);
        }

        static void PrintResult(Dictionary<string, Dictionary<string, int>> cityProfit)
        {
            foreach (KeyValuePair<string, Dictionary<string, int>> cityEntry in cityProfit)
            {
                string city = cityEntry.Key;
                Dictionary<string, int> singerProfit = cityEntry.Value
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine(city);

                foreach (KeyValuePair<string, int> singerProfitPair in singerProfit)
                {
                    string singer = singerProfitPair.Key;
                    int profit = singerProfitPair.Value;

                    Console.WriteLine($"#  {singer} -> {profit}");
                }
            }
        }

        static void InsertProfit(Dictionary<string, Dictionary<string, int>> cityProfit, string city, string singer, int profit)
        {
            if (!cityProfit[city].ContainsKey(singer))
                cityProfit[city][singer] = 0;

            cityProfit[city][singer] += profit;
        }

        static void InsertCity(Dictionary<string, Dictionary<string, int>> cityProfit, string city)
        {
            if (!cityProfit.ContainsKey(city))
                cityProfit[city] = new Dictionary<string, int>();
        }

        static string[] ReadInfo()
        {
            string[] singerInfo = Console.ReadLine().Split('@');

            return singerInfo;
        }
    }
}
