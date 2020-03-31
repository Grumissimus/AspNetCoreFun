using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KsiunszkiAPI.Entities
{
    public class Series
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public virtual ICollection<BookSeries> BookSeries { get; set; }
    }
}