using System.Collections.Generic;

namespace KsiunszkiAPI.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<BookTags> BookTags { get; set; }
    }
}