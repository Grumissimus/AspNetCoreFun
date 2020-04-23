using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public interface IBookBuilder
    {
        public BookBuilder SetId(int id);
        public BookBuilder SetIsbn(string ISBN);
        public Book Build();

    }
}
