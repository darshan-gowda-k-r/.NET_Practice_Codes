namespace LibraryManager.Interfaces
{
    // Interface - defines what LibraryService MUST implement
    interface ILibraryService
    {
        void AddBook(string title, string author, string genre);
        void RemoveBook(int id);
        void SearchBook(string keyword);
        void BorrowBook(int id, string borrowerName);
        void ReturnBook(int id);
        void DisplayAllBooks();
        void DisplayAvailableBooks();
        void DisplayBorrowedBooks();
    }
}