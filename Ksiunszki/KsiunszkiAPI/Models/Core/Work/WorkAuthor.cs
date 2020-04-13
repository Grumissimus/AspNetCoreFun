namespace API.Models
{
    public class WorkAuthor
    {
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}