using System;
using System.Collections.Generic;
using System.Linq;
using LibraryManager.Models;
using LibraryManager.Interfaces;
using LibraryManager.Exceptions;

namespace LibraryManager.Services
{
    // Implements ILibraryService Interface
    class LibraryService : ILibraryService
    {
        // ─── Collections ────────────────────────────────────────
        private List<Book> _books = new List<Book>();                    // List  - all books
        private Dictionary<int, string> _borrowLog = new Dictionary<int, string>(); // Dictionary - borrow history (bookId → borrowerName)
        private HashSet<string> _genres = new HashSet<string>();         // HashSet - unique genres only
        // ─────────────────────────────────────────────────────────

        private int _nextId = 1;

        public LibraryService()
        {
            // Seed default books
            SeedBooks();
        }

        private void SeedBooks()
        {
            AddBook("The Great Gatsby", "F. Scott Fitzgerald", "Fiction");
            AddBook("Clean Code", "Robert C. Martin", "Technology");
            AddBook("To Kill a Mockingbird", "Harper Lee", "Fiction");
            AddBook("Design Patterns", "Gang of Four", "Technology");
            AddBook("1984", "George Orwell", "Dystopian");
        }

        // ─── Add Book ────────────────────────────────────────────
        public void AddBook(string title, string author, string genre)
        {
            // LINQ - check if book already exists
            bool exists = _books.Any(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (exists)
                throw new DuplicateBookException(title);

            Book book = new Book(_nextId++, title, author, genre);
            _books.Add(book);
            _genres.Add(genre); // HashSet ignores duplicates automatically

            Console.WriteLine($"\n  Book '{title}' added successfully!");
        }

        // ─── Remove Book ─────────────────────────────────────────
        public void RemoveBook(int id)
        {
            Book book = GetBookById(id); // throws BookNotFoundException if not found

            if (book.IsBorrowed)
                throw new BookAlreadyBorrowedException(book.Title, book.BorrowedBy);

            _books.Remove(book);

            // LINQ - refresh genres after removal
            _genres = new HashSet<string>(_books.Select(b => b.Genre));

            Console.WriteLine($"\n  Book '{book.Title}' removed successfully!");
        }

        // ─── Search Book ─────────────────────────────────────────
        public void SearchBook(string keyword)
        {
            // LINQ - search by title, author, or genre
            var results = _books
                .Where(b => b.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            b.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            b.Genre.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .OrderBy(b => b.Title)
                .ToList();

            if (!results.Any())
            {
                Console.WriteLine($"\n  No books found for '{keyword}'");
                return;
            }

            Console.WriteLine($"\n  Search Results for '{keyword}' ({results.Count} found):");
            results.ForEach(b => b.Display());
        }

        // ─── Borrow Book ─────────────────────────────────────────
        public void BorrowBook(int id, string borrowerName)
        {
            Book book = GetBookById(id);

            if (book.IsBorrowed)
                throw new BookAlreadyBorrowedException(book.Title, book.BorrowedBy);

            book.IsBorrowed = true;
            book.BorrowedBy = borrowerName;
            _borrowLog[id] = borrowerName; // Dictionary - log who borrowed what

            Console.WriteLine($"\n  '{book.Title}' borrowed by {borrowerName} successfully!");
        }

        // ─── Return Book ─────────────────────────────────────────
        public void ReturnBook(int id)
        {
            Book book = GetBookById(id);

            if (!book.IsBorrowed)
                throw new BookNotBorrowedException(book.Title);

            Console.WriteLine($"\n  '{book.Title}' returned by {book.BorrowedBy} successfully!");

            book.IsBorrowed = false;
            book.BorrowedBy = string.Empty;
            _borrowLog.Remove(id); // Remove from borrow log Dictionary
        }

        // ─── Display All Books ───────────────────────────────────
        public void DisplayAllBooks()
        {
            if (!_books.Any())
            {
                Console.WriteLine("\n  No books in library.");
                return;
            }

            // LINQ - sort by title
            var sorted = _books.OrderBy(b => b.Title).ToList();

            Console.WriteLine($"\n  All Books ({sorted.Count} total):");
            sorted.ForEach(b => b.Display());

            // HashSet - show all unique genres
            Console.WriteLine($"\n  Genres in Library: {string.Join(", ", _genres)}");
        }

        // ─── Display Available Books ─────────────────────────────
        public void DisplayAvailableBooks()
        {
            // LINQ - filter only available books
            var available = _books
                .Where(b => !b.IsBorrowed)
                .OrderBy(b => b.Title)
                .ToList();

            Console.WriteLine($"\n  Available Books ({available.Count}):");
            if (!available.Any())
                Console.WriteLine("  No books available right now.");
            else
                available.ForEach(b => b.Display());
        }

        // ─── Display Borrowed Books ──────────────────────────────
        public void DisplayBorrowedBooks()
        {
            // LINQ - filter only borrowed books
            var borrowed = _books
                .Where(b => b.IsBorrowed)
                .OrderBy(b => b.BorrowedBy)
                .ToList();

            Console.WriteLine($"\n  Borrowed Books ({borrowed.Count}):");
            if (!borrowed.Any())
                Console.WriteLine("  No books currently borrowed.");
            else
                borrowed.ForEach(b => b.Display());
        }

        // ─── Private Helper ──────────────────────────────────────
        private Book GetBookById(int id)
        {
            // LINQ - find by id, returns null if not found
            Book? book = _books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                throw new BookNotFoundException(id);
            return book;
        }
    }
}