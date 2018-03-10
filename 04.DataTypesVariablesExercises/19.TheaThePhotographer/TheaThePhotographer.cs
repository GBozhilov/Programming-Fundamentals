using System;

public class TheaThePhotographer
{
    public static void Main()
    {
        int pictures = int.Parse(Console.ReadLine());
        int filterTimePerPicture = int.Parse(Console.ReadLine()); // in seconds
        int filterFactor = int.Parse(Console.ReadLine()); // the percentage of the total pictures that are considered “good”
        int uploadingTimePerPicture = int.Parse(Console.ReadLine());

        long totalPicturesTime = (long)pictures * filterTimePerPicture; // in seconds
        long filteredPictures = (long)Math.Ceiling(pictures * filterFactor / 100.0);
        long filteredPicturesUploadTime = filteredPictures * uploadingTimePerPicture;
        long totalTime = totalPicturesTime + filteredPicturesUploadTime;

        TimeSpan t = TimeSpan.FromSeconds(totalTime);

        string answer = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
            t.Days, t.Hours, t.Minutes, t.Seconds);

        Console.WriteLine(answer);
    }
}