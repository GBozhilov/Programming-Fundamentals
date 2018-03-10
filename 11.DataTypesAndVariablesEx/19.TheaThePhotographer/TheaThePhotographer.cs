using System;

public class TheaThePhotographer
{
    public static void Main()
    {
        var pictures = int.Parse(Console.ReadLine());
        var filterTimePerPicture = int.Parse(Console.ReadLine());
        var filterFactor = int.Parse(Console.ReadLine());
        var uploadTimePerPicture = int.Parse(Console.ReadLine());

        var filteredPictures = Math.Ceiling((double)pictures * filterFactor / 100);
        var filterTime = (long)pictures * filterTimePerPicture;
        var uploadTime = filteredPictures * uploadTimePerPicture;
        var totalTime = filterTime + uploadTime;

        TimeSpan time = TimeSpan.FromSeconds(totalTime);
        var formattedTime = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
            time.Days, time.Hours, time.Minutes, time.Seconds);

        Console.WriteLine(formattedTime);
    }
}