using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pseudonym { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public DateTime DeathDate { get; set; }
        public string DeathPlace { get; set; }
        public string Website { get; set; }
        public string Twitter { get; set; }
        public virtual ICollection<AuthorGenre> AuthorGenres { get; set; }
        public virtual ICollection<AuthorWork> AuthorWorks { get; set; }
    }
}
