using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Entities
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Aliases { get; set; }
        public DateTime BirthDay  {get; set;}
        public string BirthPlace { get; set; }
        public DateTime DeathDay  {get; set;}
        public string DeathPlace { get; set; }
        public string Website { get; set; }
        public string Twitter { get; set; }
        public string Description { get; set; }
        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}
