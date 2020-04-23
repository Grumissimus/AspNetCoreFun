namespace API.Models.Core.Authors
{
    public class AuthorScore
    {
        public int Score { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}