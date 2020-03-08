using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KsiunszkiAPI.Models
{
    public class AuthorWork
    {
        [Key, Column(Order = 1)]
        public int AuthorId { get; set; }
        [Key, Column(Order = 2)]
        public int WorkId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Work Work { get; set; }
    }
}
