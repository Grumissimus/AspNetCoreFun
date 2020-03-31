using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KsiunszkiAPI.Entities
{
    public class Author 
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Aliases { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? BirthDay { get; set; }
        public string? BirthPlace { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? DeathDay { get; set; }
        public string? DeathPlace { get; set; }
        public string? Website { get; set; }
        public string? Twitter { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}