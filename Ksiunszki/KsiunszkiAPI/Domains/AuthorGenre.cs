using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KsiunszkiAPI.Domains
{
    public class AuthorGenre
    {
        [Key, Column(Order = 1)]
        public int AuthorId { get; set; }
        [Key, Column(Order = 2)]
        public int GenreId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
