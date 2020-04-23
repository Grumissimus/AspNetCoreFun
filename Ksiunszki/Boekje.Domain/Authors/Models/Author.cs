using Boekje.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Authors.Models
{
    class Author : Entity
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public List<string> Pseudonyms { get; private set; }
        public DateTime Birthday { get; set; }
        public string BirthPlace { get; set; }
        public DateTime Deathday { get; set; }
        public string DeathPlace { get; set; }
        public string Nationality { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }

        public Author()
        {
        }
    }
}
