using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace LibraryManager
{
    public class Library
    {
        private List<Book> books;
        private const string FileName = "library.json";

        public Library()
        {
            books = LoadBooksFromFile();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void SaveLibrary()
        {
            SaveBooksToFile();
        }
        public void RemoveBook(string isbn)
        {
            var bookToRemove = books.FirstOrDefault(b => b.ISBN == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
        }
        public List<Book> GetAllBooks()
        {
            return books;
        }
        public List<Book> SearchBooks(string query)
        {
            return books.Where(b =>
                b.Title.ToLower().Contains(query) ||
                b.Author.ToLower().Contains(query) ||
                b.Year.ToString().Contains(query) ||
                b.ISBN.Contains(query)
            ).ToList();
        }
        private void SaveBooksToFile()
        {
            var json = JsonConvert.SerializeObject(books, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FileName, json);
        }
        private List<Book> LoadBooksFromFile()
        {
            if (File.Exists(FileName))
            {
                var json = File.ReadAllText(FileName);
                return JsonConvert.DeserializeObject<List<Book>>(json) ?? new List<Book>();
            }
            return new List<Book>();
        }
    }
}
