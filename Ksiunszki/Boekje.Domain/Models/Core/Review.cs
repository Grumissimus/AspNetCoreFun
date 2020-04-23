namespace API.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int WorkScoreId { get; set; }
        public virtual WorkScore WorkScore { get; set; }
    }
}