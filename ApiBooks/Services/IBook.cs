using ApiBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBooks.Services
{
    public interface IBook
    {
        IEnumerable<Book> GetBooks(string title); 
        Book GetBook(int Id);
        Status Add(Book book);
        Status Sell(int id);

        Status Update(int id,Book book);
    }
}
