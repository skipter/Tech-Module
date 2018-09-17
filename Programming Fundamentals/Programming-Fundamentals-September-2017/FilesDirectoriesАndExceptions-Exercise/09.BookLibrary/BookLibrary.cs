namespace _09.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.IO;
    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long ISBNnumber { get; set; }
        public double Price { get; set; }
    }

    public class Library
    {
        public string Book { get; set; }
        public List<Books> listOfBooks { get; set; }
    }

    public class AuthorSale
    {
        public string Author { get; set; }
        public double Sale { get; set; }
    }

    public class BookLibrary
    {
        public static void Main()
        {
            var dataFromFile = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            var books = new List<Books>();
            var library = new Library()
            {
                Book = "Libra",
                listOfBooks = new List<Books>()
            };

            foreach (var bookInsertion in dataFromFile)
            {
                var input = bookInsertion.Split(' ').ToList();
                Books book = new Books();

                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBNnumber = long.Parse(input[4]);
                book.Price = double.Parse(input[5]);
                library.listOfBooks.Add(book);
            }

            var autoSales = new List<AuthorSale>();
            var authors = library.listOfBooks.Select(a => a.Author).Distinct().ToArray();

            foreach (var author in authors)
            {
                var sales = library.listOfBooks.Where(a => a.Author == author).Sum(a => a.Price);
                autoSales.Add(new AuthorSale()
                {
                    Author = author,
                    Sale = sales
                });
            }
            autoSales = autoSales.OrderByDescending(a => a.Sale).ThenBy(a => a.Author).ToList();
            foreach (var sale in autoSales)
            {
                string output = $"{sale.Author} -> {sale.Sale:F2}" + Environment.NewLine;
                File.AppendAllText("output.txt", output);
            }
        }
    }
}
