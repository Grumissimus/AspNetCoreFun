using KsiunszkiAPI.Entities;
using KsiunszkiAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

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

        public List<Book> GetByAuthor(int authorId)
        {
            var bookList = Context.Books.Where(a => a.AuthorBooks.Any(c => c.AuthorId == authorId)).ToList();
            return bookList;
        }

        public void AddAuthor(int bookId, int authorId)
        {
            var book = GetById(bookId);
            var author = Context.Authors.FirstOrDefault(a => a.Id == authorId);

            if (book == null || author == null)
                return;

            AuthorBook authorBook = new AuthorBook { Author = author, Book = book };
            book.AuthorBooks.Add(authorBook);
            Context.SaveChanges();
        }

        public void RemoveAuthor(int bookId, int authorId)
        {
            var book = GetById(bookId);
            var author = Context.Authors.FirstOrDefault(a => a.Id == authorId);

            if (book == null || author == null)
                return;

            AuthorBook authorBook = book.AuthorBooks.Single(ab => ab.AuthorId == authorId && ab.BookId == bookId);
            book.AuthorBooks.Add(authorBook);
            Context.SaveChanges();
        }

        public void Insert(Book book)
        {
            Context.Books.Add(book);
            Context.SaveChanges();
        }

        public void Update(int id, Book book)
        {
            if (book == null)
                return;

            var oldBook = GetById(id);

            if (oldBook == null)
                return;

            oldBook.Id = id;

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
