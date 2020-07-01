using Boekje.Common.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Boekje.Domain.Models
{
    public class Author : Entity
    {
        public string Name { get; private set; }
        public virtual ICollection<AuthorWork> AuthorWorks { get; private set; }
        public virtual List<Work> Works { get => AuthorWorks.Select(x => x.Work).ToList(); }
    }
}
