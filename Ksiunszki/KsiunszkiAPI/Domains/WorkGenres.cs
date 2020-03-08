using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KsiunszkiAPI.Domains
{
    public class WorkGenres
    {
        [Key, Column(Order = 1)]
        public int WorkId { get; set; }
        [Key, Column(Order = 2)]
        public int GenresId { get; set; }
        public virtual Work Work { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
