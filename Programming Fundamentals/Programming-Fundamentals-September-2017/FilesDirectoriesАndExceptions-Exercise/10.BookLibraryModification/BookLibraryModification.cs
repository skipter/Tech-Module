namespace _10.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.IO;
    public class Books
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            var inputDataLibrary = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            var books = new List<Books>();

            foreach (var bookData in inputDataLibrary)
            {
                var input = bookData.Split(' ').ToList();
                if (input.Count <= 1)
                {
                    continue;
                }
                var book = new Books();

                book.Name = input[0];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                books.Add(book);
            }

            var date = DateTime.ParseExact(inputDataLibrary.Last(), "dd.MM.yyyy", CultureInfo.InvariantCulture); //Input the date to check

            foreach (var book in books.OrderBy(d => d.ReleaseDate).ThenBy(a => a.Name))
            {
                if (book.ReleaseDate > date)
                {
                    File.AppendAllText("output.txt", $"{book.Name} -> " +
                        $"{book.ReleaseDate.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)}" + Environment.NewLine);
                }
            }
        }
    }
}