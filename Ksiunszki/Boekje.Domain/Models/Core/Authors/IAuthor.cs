using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Core.Authors
{
    public interface IAuthor
    {   
        int Id { get; set; }
        string Name { get; set; }
        DateTime Birthday { get; set; }
        string BirthPlace { get; set; }
        DateTime Deathday { get; set; }
        string DeathPlace { get; set; }
        string Nationality { get; set; }
        Gender Gender { get; set; }
        string Description { get; set; }
    }
}
