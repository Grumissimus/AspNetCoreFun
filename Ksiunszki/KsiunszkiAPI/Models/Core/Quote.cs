namespace API.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public virtual Work Work { get; set; }
        public virtual Author Author { get; set; }
    }
}