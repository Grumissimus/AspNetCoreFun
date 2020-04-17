using System;
using System.Collections.Generic;
using API.Models.Core.Author;

namespace API.Models
{
    public class Author
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

        public virtual ICollection<WorkAuthor> Works { get; set; }
        public virtual ICollection<AuthorScore> UserScores { get; set; }
        public virtual ICollection<FavoriteAuthor> UserFavorites { get; set; }
        public virtual ICollection<AuthorAward> Awards { get; set; }
        public virtual ICollection<AuthorTag> Tags { get; set; }

        public Author()
        {

        }
    }
}