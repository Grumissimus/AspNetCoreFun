namespace API.Models
{
    public class WorkTag
    {
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}