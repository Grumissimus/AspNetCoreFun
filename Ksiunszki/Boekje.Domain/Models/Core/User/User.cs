using System;
using System.Collections.Generic;
using API.Models.Core.Authors;

namespace API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Salt { get; set; }
        public string PassHash { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LoginDate { get; set; }

        public virtual ICollection<AuthorScore> AuthorScores { get; set; }
        public virtual ICollection<WorkScore> WorkScores { get; set; }

        public virtual ICollection<FavoriteAuthor> FavoriteAuthors { get; set; }
        public virtual ICollection<FavoriteWork> FavoriteWorks { get; set; }
    }
}