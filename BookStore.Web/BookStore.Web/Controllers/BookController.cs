using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Core.DAL.Interfaces;
using BookStore.Core.DAL.Repository;
using BookStore.Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _iBookRepository;
        public BookController()
        {
            _iBookRepository = new BookRepository();
        }
        public List<Book> GetAllBook()
        {
            return _iBookRepository.GetAllBooks().ToList();
        }
        public Book GetBook(int id)
        {
            return _iBookRepository.GetBook(id);
        }
        public List<Book> SearchBook(string title, string authorName)
        {
            return _iBookRepository.SearchBook(title, authorName).ToList();
        }
    }
}