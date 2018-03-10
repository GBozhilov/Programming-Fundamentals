using System;
using System.Collections.Generic;
using System.Linq;

public class Files
{
    public static void Main()
    {
        var filesByRoot = new Dictionary<string, Dictionary<string, long>>();
        var filesWithExtension = new Dictionary<string, string>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var inputParts = Console.ReadLine().Split(new char[] { '\\' },
                StringSplitOptions.RemoveEmptyEntries);

            var root = inputParts[0];

            var fileParts = inputParts.Last().Split(new char[] { ';' },
                StringSplitOptions.RemoveEmptyEntries);

            var nameWithExtension = fileParts.First();
            var size = long.Parse(fileParts.Last());

            var name = nameWithExtension;
            var extension = nameWithExtension.Split('.').Last();

            if (!filesByRoot.ContainsKey(root))
            {
                filesByRoot[root] = new Dictionary<string, long>();
            }

            filesByRoot[root][name] = size;
            filesWithExtension[name] = extension;
        }

        var queryParts = Console.ReadLine().Split(' ');

        var queryExtension = queryParts.First();
        var queryRoot = queryParts.Last();

        var extractedFiles = new Dictionary<string, long>();

        if (filesByRoot.ContainsKey(queryRoot))
        {
            foreach (var nameSizePair in filesByRoot[queryRoot])
            {
                if (filesWithExtension[nameSizePair.Key] == queryExtension)
                {
                    extractedFiles.Add(nameSizePair.Key, nameSizePair.Value);
                }
            }
        }

        extractedFiles = extractedFiles
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, y => y.Value);

        foreach (var nameSizePair in extractedFiles)
        {
            var name = nameSizePair.Key;
            var size = nameSizePair.Value;

            Console.WriteLine($"{name} - {size} KB ");
        }

        if (!extractedFiles.Any())
        {
            Console.WriteLine("No");
        }
    }
}