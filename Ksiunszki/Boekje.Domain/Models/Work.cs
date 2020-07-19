using Boekje.Common.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Boekje.Core.Domain.Models
{
    public class Work : Entity
    {
        public string Title { get; private set; }
        public virtual ICollection<AuthorWork> AuthorWorks { get; private set; }
        public virtual List<Author> Authors { get => AuthorWorks.Select(x => x.Author).ToList(); }
        public virtual ICollection<Book> Books { get; private set; }
        public Book RepresentativeBook { get => Books?.FirstOrDefault(); }
        public long RepresentativeBookId { get => RepresentativeBook != null ? RepresentativeBook.Id : 0; }
    }
}
