using System;
using System.IO;

public class FolderSize
{
    public static void Main()
    {
        string[] filesInDir = Directory.GetFiles("../../TestFolder");

        double directorySize = 0;

        foreach (var file in filesInDir)
        {
            var fileInfo = new FileInfo(file);

            directorySize += fileInfo.Length; // in bytes
        }

        var sizeInMegabytes = directorySize / 1024 / 1024;

        Console.WriteLine(sizeInMegabytes);
        File.WriteAllText("../../result.txt", sizeInMegabytes.ToString());
    }
}