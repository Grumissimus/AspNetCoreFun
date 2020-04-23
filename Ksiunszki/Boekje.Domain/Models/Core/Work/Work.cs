using System.Collections.Generic;

namespace API.Models
{
    public class Work
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string OriginalLanguage { get; set; }

        public int? FranchiseId { get; set; }
        public virtual Franchise Franchise { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public virtual ICollection<WorkAuthor> Authors { get; set; }
        public virtual ICollection<WorkSeries> Series { get; set; }
        public virtual ICollection<WorkUserList> UserLists { get; set; }
        public virtual ICollection<WorkTag> Tags { get; set; }
        public virtual ICollection<WorkScore> UserScores { get; set; }
        public virtual ICollection<FavoriteWork> UserFavorites { get; set; }
        public virtual ICollection<CharacterWork> Characters { get; set; }
        public virtual ICollection<WorkAward> Awards { get; set; }
    }
}