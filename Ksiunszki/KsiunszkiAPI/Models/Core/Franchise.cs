using System.Collections.Generic;

namespace API.Models
{
    public class Franchise
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Work> Works { get; set; }
    }
}