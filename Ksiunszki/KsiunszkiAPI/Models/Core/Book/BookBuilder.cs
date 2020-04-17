using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class BookBuilder : IBookBuilder
    {
        private Book _book;

        public BookBuilder()
        {
            _book = new Book();
        }

        public BookBuilder SetId(int id)
        {
            _book.Id = id;
            return this;
        }

        public BookBuilder SetIsbn(string ISBN)
        {
            return this;
        }

        public Book Build()
        {
            return _book;
        }
    }
}
