using ApiBooks.Models;
using ApiBooks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBooks.Repository
{
    public class BookRepository : IBook
    {
        private DB_Context db;

        public BookRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Book> GetBooks(string title)
        {
            if (title!=null){
                return db.Books.Where(book => book.Title.Contains(title));
            }
            else
            {
                return db.Books;
            }
        }

        public Status Sell(int id)
        {
            var book = db.Books.Where(b => b.BookId == id).FirstOrDefault();
            if (book == null)
            {
                return new Status("Error");
            }
            else
            {
                db.Books.Remove(book);
                db.SaveChanges();
                return new Status("Success");
            }
        }

        public Status Update(int id,Book book)
        {
            Book book_updated = db.Books.Where(b => b.BookId == id).FirstOrDefault();
            if (book_updated==null)
            {
                return new Status("Not found");
            }
            book_updated.Author = book.Author;
            book_updated.Title = book.Title;
            book_updated.Image = book.Image;
            book_updated.Price = book.Price;
            book_updated.Rating = book_updated.Rating;
            db.SaveChanges();
            return new Status("Success");
        }

        Status IBook.Add(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return new Status("Success");
        }

        Book IBook.GetBook(int Id)
        {
            return db.Books.Where(book => book.BookId == Id).FirstOrDefault();
        }
    }
}
