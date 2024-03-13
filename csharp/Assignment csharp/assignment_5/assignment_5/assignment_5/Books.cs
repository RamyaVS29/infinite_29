using System;
namespace assignment_5
{
    public class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine($"Book: {BookName}, Author: {AuthorName}");
        }
    }

    public class BookShelf
    {
        private Books[] books;

        public BookShelf(int value)
        {
            books = new Books[value];
        }

        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                {
                    return books[index];
                }
                else
                {
                    Console.WriteLine("Invalid index");
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < books.Length)
                {
                    books[index] = value;
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
        }

        public int Length => books.Length;

        public void DisplayBooks()
        {
            Console.WriteLine("Bookshelf Contents:");
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    Console.Write($"{i + 1}. ");
                    books[i].Display();
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
           
            BookShelf bookShelf = new BookShelf(5);//creating a bookself 

            for (int i = 0; i < bookShelf.Length; i++) //getinputs
            {
                Console.WriteLine($"Enter details for Book {i + 1}:");
                Console.Write("Book Name: ");
                string bookName = Console.ReadLine();

                Console.Write("Author Name: ");
                string authorName = Console.ReadLine();

                Books book = new Books(bookName, authorName);
                bookShelf[i] = book;
            }
            bookShelf.DisplayBooks();
            Console.ReadLine();
        }
    }
}

