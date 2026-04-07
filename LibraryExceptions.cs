using System;

namespace LibraryManager.Exceptions
{
    // Custom Exception 1 - Book not found
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(int id)
            : base($"Book with ID {id} was not found.") { }
    }

    // Custom Exception 2 - Book already borrowed
    class BookAlreadyBorrowedException : Exception
    {
        public BookAlreadyBorrowedException(string title, string borrower)
            : base($"'{title}' is already borrowed by {borrower}.") { }
    }

    // Custom Exception 3 - Book not borrowed (cant return)
    class BookNotBorrowedException : Exception
    {
        public BookNotBorrowedException(string title)
            : base($"'{title}' is not currently borrowed.") { }
    }

    // Custom Exception 4 - Duplicate book
    class DuplicateBookException : Exception
    {
        public DuplicateBookException(string title)
            : base($"'{title}' already exists in the library.") { }
    }
}