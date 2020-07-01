﻿using Boekje.Common.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Boekje.Domain.Models
{
    public class Work : Entity
    {
        public string Title { get; private set; }
        public virtual ICollection<AuthorWork> AuthorWorks { get; private set; }
        public virtual List<Author> Authors { get => AuthorWorks.Select(x => x.Author).ToList(); }
        public virtual ICollection<Book> Books { get; private set; }
    }
}
