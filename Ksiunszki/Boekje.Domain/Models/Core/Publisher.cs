using System.Collections.Generic;

namespace API.Models
{
    public class Publisher
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}