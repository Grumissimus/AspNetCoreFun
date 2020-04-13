namespace API.Models
{
    public class WorkAward
    {
        public string Title { get; set; }
        public short Year { get; set; }

        public int WorkId { get; set; }
        public virtual Work Work { get; set; }

        public int AwardId { get; set; }
        public virtual Award Award { get; set; }
    }
}