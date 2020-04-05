using KsiunszkiAPI.Entities;
using KsiunszkiAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class BookService : IBookService
    {
        private KsiunszkiContext Context { get; set; }

        public BookService(KsiunszkiContext context)
        {
            Context = context;
        }

        public Book GetById(int id)
        {
            return Context.Books.FirstOrDefault(a => a.Id == id); ;
        }

        public Book GetByISBN(string ISBN)
        {
            return Context.Books.FirstOrDefault(a => a.ISBN == ISBN );
        }

        public List<Book> GetByTitle(string Title)
        {
            var bookList = from m in Context.Books
                           where m.Title.Contains(Title) || m.OriginalTitle.Contains(Title)
                           select m;

            return bookList.ToList();
        }

        public void Insert(Book book)
        {
            Context.Books.Add(book);
            Context.SaveChanges();
        }

        public void Update(int id, Book book)
        {
            var oldBook = GetById(id);

            if (oldBook == null)
                return;

            book.Id = id;

            Context.Entry(oldBook).CurrentValues.SetValues(book);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = GetById(id);

            Context.Books.Remove(book);
            Context.SaveChanges();
        }

    }
}
