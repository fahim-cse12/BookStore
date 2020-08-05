using BookStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.DAL.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBook(int id);
        IEnumerable<Book> SearchBook(string title, string authorName);
    }
}
