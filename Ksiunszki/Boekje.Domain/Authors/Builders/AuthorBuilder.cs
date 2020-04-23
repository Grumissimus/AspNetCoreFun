using Boekje.Domain.Authors.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Authors.Builders
{
    public class AuthorBuilder : IAuthorBuilder
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<string> Aliases { get; set; }
        public DatePlace Birth { get; set; }
        public DatePlace Death { get; set; }
        public Gender Gender { get; set; }
        public string Nationality { get; set; }
        public string Description { get; set; }

        private AuthorBuilder()
        {
        }

        public static AuthorBuilder Start()
        {
            return new AuthorBuilder();
        }

        public Author Build()
        {
            return new Author(this);
        }

        public IAuthorBuilder Reset()
        {
            return Start();
        }

        public IAuthorBuilder SetId(int id)
        {
            if (id < 1)
                throw new ArgumentException(nameof(id), "Identifier cannot be lower than one.");

            Id = id;
            return this;
        }

        public IAuthorBuilder SetAliases(List<string> aliases)
        {
            Aliases = aliases;
            return this;
        }

        public IAuthorBuilder SetBirthday(DatePlace birthDatePlace)
        {
            Birth = birthDatePlace;
            return this;
        }

        public IAuthorBuilder SetDeathday(DatePlace deathDatePlace)
        {
            Death = deathDatePlace;
            return this;
        }

        public IAuthorBuilder SetDescription(string description)
        {
            Nationality = description;
            return this;
        }

        public IAuthorBuilder SetGender(Gender gender)
        {
            Gender = gender;
            return this;
        }

        public IAuthorBuilder SetName(string name)
        {
            Name = name;
            return this;
        }

        public IAuthorBuilder SetNationality(string nationality)
        {
            Description = nationality;
            return this;
        }

    }
}
