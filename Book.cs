using System;

namespace LibraryManager.Models
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public bool IsBorrowed { get; set; } = false;
        public string BorrowedBy { get; set; } = string.Empty;

        // Parameterized Constructor
        public Book(int id, string title, string author, string genre)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
        }

        public void Display()
        {
            string status = IsBorrowed ? $"Borrowed by {BorrowedBy}" : "Available";
            Console.WriteLine($"  [{Id}] {Title} by {Author} | Genre: {Genre} | {status}");
        }
    }
}using System;

public class Class1
{
	public Class1()
	{
	}
}
