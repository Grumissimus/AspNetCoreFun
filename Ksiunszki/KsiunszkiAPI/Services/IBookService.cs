using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Services
{
    public interface IBookService : IService<Book>
    {
        public List<Book> Read(string Title);
        public Book ReadByISBN(string ISBN);
        public List<Book> ReadByAuthor(int authorId);
    }
}
