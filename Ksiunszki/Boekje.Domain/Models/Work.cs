using Boekje.Common.Entities;
using System.Collections.Generic;

namespace Boekje.Domain.Models
{
    public class Work : Entity
    {
        public string Title { get; private set; }
        public long AuthorId { get; private set; }
        public virtual ICollection<Author> Authors { get; private set; }
        public virtual ICollection<Book> Books { get; private set; }
    }
}
