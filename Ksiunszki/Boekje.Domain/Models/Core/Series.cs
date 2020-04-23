using System.Collections.Generic;

namespace API.Models
{
    public class Series
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<WorkSeries> Works { get; set; }
    }
}