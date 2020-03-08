using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KsiunszkiAPI.Models
{   public class Work
    {
        [Key]
        public int WorkId { get; set; }
        [Required]
        public string Title { get; set; }
        public virtual ICollection<AuthorWork> AuthorWorks { get; set; }
    }
}