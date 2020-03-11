using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Domains
{
    public class Author : IBirthDate, IDeathDate
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pseudonym { get; set; }
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public string BirthPlace { get; set; }
        public int DeathYear { get; set; }
        public int DeathMonth { get; set; }
        public int DeathDay { get; set; }
        public string DeathPlace { get; set; }
        public string Website { get; set; }
        public string Twitter { get; set; }
        public virtual ICollection<AuthorGenre> AuthorGenres { get; set; }
        public virtual ICollection<AuthorWork> AuthorWorks { get; set; }

        public void SetBirthDate(DateTime date)
        {
            BirthYear = date.Year;
            BirthMonth = date.Month;
            BirthDay = date.Day;
        }

        public void SetDeathDate(DateTime date)
        {
            DeathYear = date.Year;
            DeathMonth = date.Month;
            DeathDay = date.Day;
        }
    }
}
