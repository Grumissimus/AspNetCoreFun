using API.Requests;
using KsiunszkiAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Services
{
    public interface IBookService
    {
        public Book GetById(int id);
        public Book GetByISBN(string ISBN);
        public List<Book> GetByTitle(string Title);
        public void Insert(Book book);
        public void Update(int id, Book author);
        public void Delete(int id);
    }
}
