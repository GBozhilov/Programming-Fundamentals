using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class BookLibrary
{
    public static void Main()
    {
        var books = ReadBooks();

        var library = new Library() { Books = books };

        var authors = library.Books
            .Select(b => b.Author)
            .Distinct()
            .ToArray();

        var authorSales = new List<AuthorInfo>();

        foreach (var author in authors)
        {
            var sales = library.Books
                .Where(a => a.Author == author)
                .ToArray()
                .Sum(a => a.Price);

            var authorInfo = new AuthorInfo()
            {
                Author = author,
                Sales = sales
            };

            authorSales.Add(authorInfo);
        }

        authorSales = authorSales
            .OrderByDescending(a => a.Sales)
            .ThenBy(a => a.Author)
            .ToList();

        foreach (var authorInfo in authorSales)
        {
            Console.WriteLine($"{authorInfo.Author} -> {authorInfo.Sales:F2}");
        }
    }

    public static List<Book> ReadBooks()
    {
        var books = new List<Book>();

        var booksCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < booksCount; i++)
        {
            var bookParams = Console.ReadLine().Split(' ');

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

public class AuthorInfo
{
    public string Author { get; set; }

    public decimal Sales { get; set; }
}

public class Library
{
    public string Name { get; set; }

    public List<Book> Books { get; set; }
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

