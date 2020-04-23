using System.Collections.Generic;
using API.Models.Core.Authors;

namespace API.Models
{
    public class Tag
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public bool Spoilerific { get; set; }

        public virtual ICollection<WorkTag> Works { get; set; }
        public virtual ICollection<AuthorTag> Authors { get; set; }
    }
}