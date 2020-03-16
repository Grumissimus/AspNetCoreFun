using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Entities
{
    public class Series
    {
        [Key]
        public int SeriesId { get; set; }
        [Required]
        public string SeriesName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<BookSeries> BookSeries {get; set;}
    }
}
