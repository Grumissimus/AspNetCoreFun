using Boekje.Domain.Authors.Models;
using System;
using System.Collections.Generic;

namespace API.Models.Core.Authors
{
    public class Author : IAuthor
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

        public virtual IReadOnlyCollection<WorkAuthor> Works { get; set; }
        public virtual IReadOnlyCollection<AuthorScore> UserScores { get; set; }
        public virtual IReadOnlyCollection<FavoriteAuthor> UserFavorites { get; set; }
        public virtual IReadOnlyCollection<AuthorAward> Awards { get; set; }
        public virtual IReadOnlyCollection<AuthorTag> Tags { get; set; }

        public Author()
        {
        }

        public Author(AuthorBuilder builder)
        {

        }
    }
}