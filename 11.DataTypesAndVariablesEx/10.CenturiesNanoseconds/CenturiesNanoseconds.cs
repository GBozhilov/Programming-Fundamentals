using System;
using System.Numerics;

public class CenturiesToNanoseconds
{
    public static void Main()
    {
        byte centuries = byte.Parse(Console.ReadLine());
        ushort years = (ushort)(centuries * 100);
        int days = (int)(years * 365.24219);
        int hours = (days * 24);
        ulong minutes = (ulong)(hours * 60);
        ulong seconds = minutes * 60;
        ulong miliSeconds = seconds * 1000;
        BigInteger microSeconds = miliSeconds * 1000;
        BigInteger nanoSeconds = microSeconds * 1000;

        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
            centuries, years, days, hours, minutes, seconds, miliSeconds, microSeconds, nanoSeconds);
    }
}