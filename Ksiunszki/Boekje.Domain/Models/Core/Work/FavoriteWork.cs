namespace API.Models
{
    public class FavoriteWork
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
    }
}