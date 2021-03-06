﻿namespace Boekje.Core.Domain.Models
{
    public class AuthorBook
    {
        public long AuthorId { get; private set; }
        public Author Author { get; private set; }
        public string Role { get; private set; }
        public long BookId { get; private set; }
        public Book Book { get; private set; }
    }
}
