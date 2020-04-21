using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Core.Authors
{
    interface IAuthor
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string BirthPlace { get; set; }
        public DateTime Deathday { get; set; }
        public string DeathPlace { get; set; }
        public string Nationality { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }
    }
}
