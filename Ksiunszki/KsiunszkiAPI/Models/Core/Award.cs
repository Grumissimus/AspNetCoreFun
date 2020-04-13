using System.Collections.Generic;

namespace API.Models
{
    public class Award
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<WorkAward> Works { get; set; }
        public virtual ICollection<AuthorAward> Authors { get; set; }
    }
}