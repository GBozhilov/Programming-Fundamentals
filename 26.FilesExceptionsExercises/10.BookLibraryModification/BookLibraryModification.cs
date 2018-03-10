using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

public class BookLibraryModification
{
    public static void Main()
    {
        var lines = File.ReadAllLines("input.txt");

        var books = ReadBooks(lines);

        var minDate = DateTime.ParseExact(lines.Last(), "dd.MM.yyyy",
            CultureInfo.InvariantCulture);

        List<TitleDate> titleDates = ReadTitleDates(books);

        titleDates = titleDates
            .Where(a => a.ReleaseDate > minDate)
            .OrderBy(a => a.ReleaseDate)
            .ThenBy(a => a.Title)
            .ToList();

        var output = new StringBuilder();

        foreach (var entry in titleDates)
        {
            var title = entry.Title;
            var date = string.Format(entry.ReleaseDate.ToString("dd.MM.yyyy"));

            Console.WriteLine($"{title} -> {date}");
            output.AppendLine($"{title} -> {date}");
        }

        File.WriteAllText("output.txt", output.ToString());
    }

    public static List<TitleDate> ReadTitleDates(List<Book> books)
    {
        var titleDates = new List<TitleDate>();

        foreach (var book in books)
        {
            var title = book.Title;
            var releaseDate = book.ReleaseDate;

            var titleDate = new TitleDate() { Title = title, ReleaseDate = releaseDate };

            titleDates.Add(titleDate);
        }

        return titleDates;
    }

    public static List<Book> ReadBooks(string[] inputLines)
    {
        var books = new List<Book>();

        var booksCount = int.Parse(inputLines[0]);

        for (int i = 1; i < inputLines.Length - 1; i++)
        {
            var bookParams = inputLines[i].Split(' ');

            var title = bookParams[0];
            var author = bookParams[1];
            var publisher = bookParams[2];
            var releaseDate = DateTime.ParseExact(bookParams[3], "dd.MM.yyyy",
                CultureInfo.InvariantCulture);
            var isbn = bookParams[4];
            var price = decimal.Parse(bookParams[5]);

            var newBook = new Book()
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                ReleaseDate = releaseDate,
                Isbn = isbn,
                Price = price
            };

            books.Add(newBook);
        }

        return books;
    }
}

public class TitleDate
{
    public string Title { get; set; }

    public DateTime ReleaseDate { get; set; }
}

public class Book
{
    public string Title { get; set; }

    public string Author { get; set; }

    public string Publisher { get; set; }

    public DateTime ReleaseDate { get; set; }

    public string Isbn { get; set; }

    public decimal Price { get; set; }
}