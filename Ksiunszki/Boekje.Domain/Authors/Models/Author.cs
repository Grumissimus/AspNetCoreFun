using Boekje.Domain.Authors.Builders;
using Boekje.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Authors.Models
{
    public class Author : Entity
    {
        public string Name { get; private set; }
        public List<string> Aliases { get; private set; }
        public DatePlace Birth { get; private set; }
        public DatePlace Death { get; private set; }
        public string Nationality { get; private set; }
        public Gender Gender { get; private set; }
        public string Description { get; private set; }

        public Author()
        {
        }

        public Author(AuthorBuilder author)
        {
            if (author == null)
                throw new ArgumentNullException(nameof(author), "The builder cannot be null.");

            if (string.IsNullOrEmpty(author.Name))
                throw new ArgumentNullException(nameof(author.Name), "The author name cannot be null or empty");


        }

    }
}
