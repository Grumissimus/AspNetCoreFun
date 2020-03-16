using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KsiunszkiAPI.Entities
{
    public class List
    {
        [Key]
        public int ListId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<BookLists> BookLists { get; set; }
    }
}
