using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Models
{
    public class AuthorWork
    {
        public long AuthorId { get; private set; }
        public Author Author { get; private set; }
        public long WorkId { get; private set; }
        public Work Work { get; private set; }
    }
}
