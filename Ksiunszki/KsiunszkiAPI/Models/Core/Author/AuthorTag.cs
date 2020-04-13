namespace API.Models
{
    public class AuthorTag
    {
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}