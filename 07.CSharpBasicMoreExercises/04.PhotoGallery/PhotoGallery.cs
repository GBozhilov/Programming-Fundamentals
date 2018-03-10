using System;

public class PhotoGallery
{
    public static void Main()
    {
        var photoNumber = int.Parse(Console.ReadLine());
        var day = int.Parse(Console.ReadLine());
        var month = int.Parse(Console.ReadLine());
        var year = int.Parse(Console.ReadLine());
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var sizeInBytes = int.Parse(Console.ReadLine());
        var width = int.Parse(Console.ReadLine());
        var height = int.Parse(Console.ReadLine());

        var orientation = string.Empty;

        if (width > height)
        {
            orientation = "landscape";
        }
        else if (width < height)
        {
            orientation = "portrait";
        }
        else
        {
            orientation = "square";
        }

        var size = string.Empty;

        if (sizeInBytes >= 1000000)
        {
            var megabytes = sizeInBytes / 1000000;
            size = megabytes + "MB";
        }
        else if (sizeInBytes >= 1000)
        {
            var kilobytes = sizeInBytes / 1000;
            size = kilobytes + "KB";
        }
        else
        {
            size = sizeInBytes + "B";
        }

        Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
        Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
        Console.WriteLine($"Size: {size}");
        Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
    }
}