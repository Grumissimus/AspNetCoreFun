namespace API.Models
{
    public class FavoriteAuthor
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}