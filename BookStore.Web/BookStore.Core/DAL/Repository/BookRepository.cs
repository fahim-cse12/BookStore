using BookStore.Core.DAL.Interfaces;
using BookStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Core.DAL.Repository
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> GetAllBooks()
        {
            return DataSource();
        }

        public Book GetBook(int id)
        {
            return DataSource().Where(i => i.Id == id).FirstOrDefault();
        }

        public IEnumerable<Book> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<Book> DataSource()
        {
            return new List<Book>()
            {
                new Book(){ Id=1,Title="C#",Author="Microsoft"},
                new Book(){ Id=2,Title="Angular",Author="Google"},
                new Book(){ Id=3,Title="React",Author="Facebook"},
                new Book(){ Id=4,Title="Blazor",Author="Mono"},
                new Book(){ Id=5,Title="Flutter",Author="Google"}
            };
        }

    }
}
