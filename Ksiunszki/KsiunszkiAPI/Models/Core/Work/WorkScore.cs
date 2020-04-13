namespace API.Models
{
    public class WorkScore
    {
        public int Id { get; set; }
        public int Score { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
    }
}