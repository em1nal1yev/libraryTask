using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryTask
{
    class Library
    {
        public string Name { get; set; }
        public Library(string name)
        {
            Name = name;
        }
        Book[] books = new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[^1] = book;
        }
        public Book GetBookById(int id)
        {
            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    return item;
                    break;
                }
            }
            return null;
        }

        public void RemoveBook(int id)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Id == id)
                {
                    Book book = books[books.Length - 1];
                    books[books.Length - 1] = books[i];
                    books[i] = book;
                    Array.Resize(ref books, books.Length - 1);
                    break;
                }
                else
                {
                    Console.WriteLine("Bu kitab yoxdu kitabxanada.");
                }
            }
        }

        public Book[] GetBook(string name)
        {
            Book[] bookss = new Book[0];
            foreach (var book in books)
            {
                if(name == book.Name)
                {
                    Array.Resize(ref bookss, bookss.Length + 1);
                    bookss[^1] = book;
                }
            }
            return bookss;
        }

        public void GetAllBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.ShowInfo());
            }
        }

        public void Update(int id, Book book)
        {
            for(int i =0;i<books.Length; i++)
            {
                if(id == books[i].Id)
                {
                    books[i] = book;
                }
            }
        }

    }
}
