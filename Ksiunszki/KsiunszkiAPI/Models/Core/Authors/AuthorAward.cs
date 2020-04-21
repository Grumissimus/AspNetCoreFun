namespace API.Models.Core.Authors
{
    public class AuthorAward
    {
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public int AwardId { get; set; }
        public virtual Award Award { get; set; }

        public string Title { get; set; }
        public short Year { get; set; }

    }
}