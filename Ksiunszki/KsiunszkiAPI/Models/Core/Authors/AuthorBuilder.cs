using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Core.Authors
{
    public class AuthorBuilder : IAuthorBuilder, IAuthor
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

        public IAuthorBuilder SetBirthDay(DateTime birthday)
        {
            Birthday = birthday;
            return this;
        }

        public IAuthorBuilder SetBirthPlace(string birthPlace)
        {
            BirthPlace = birthPlace;
            return this;
        }

        public IAuthorBuilder SetDeathDay(DateTime deathday)
        {
            Deathday = deathday;
            return this;
        }

        public IAuthorBuilder SetDeathPlace(string deathPlace)
        {
            DeathPlace = deathPlace;
            return this;
        }

        public IAuthorBuilder SetDescription(string description)
        {
            Description = description;
            return this;
        }

        public IAuthorBuilder SetGender(Gender gender)
        {
            Gender = gender;
            return this;
        }

        public IAuthorBuilder SetId(int id)
        {
            if(id < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "The primary key identifier cannot have value lower than one.");
            }

            Id = id;

            return this;
        }

        public IAuthorBuilder SetName(string name)
        {
            Name = name;
            return this;
        }

        public IAuthorBuilder SetNationality(string nationality)
        {
            Nationality = nationality;
            return this;
        }
        public Author Build()
        {
            return new Author(this);
        }
    }
}
