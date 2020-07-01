using Boekje.Common.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Boekje.Domain.Models
{
    public class Book : Entity
    {
        public ISBN ISBN { get; private set; }
        public string Title { get; private set; }
        public Publisher Publisher { get; private set; }
        public Work Work { get; private set; }
        public short Pages { get; private set; }
        public virtual ICollection<AuthorBook> AuthorBooks { get; private set; }
        public List<Author> Authors => AuthorBooks.Select(x => x.Author).ToList();
    }
}
