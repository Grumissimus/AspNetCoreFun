using API.Services;
using KsiunszkiAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Services
{
    public interface IBookService : IService<Book>
    {
        public List<Book> Read(string Title);
        public Book ReadByISBN(string ISBN);
        public List<Book> ReadByAuthor(int authorId);
    }
}
