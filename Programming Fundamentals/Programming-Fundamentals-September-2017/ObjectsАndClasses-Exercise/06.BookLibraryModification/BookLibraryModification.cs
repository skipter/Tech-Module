namespace _06.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    public class Books
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var books = new List<Books>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var book = new Books();

                book.Name = input[0];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                books.Add(book);
            }
            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture); //Input the date to check

            foreach (var book in books.OrderBy(d => d.ReleaseDate).ThenBy(a => a.Name))
            {
                if (book.ReleaseDate > date)
                {
                    Console.WriteLine("{0} -> {1:dd.MM.yyyy}", book.Name, book.ReleaseDate);
                }
            }
        }
    }
}