namespace API.Models
{
    public class WorkSeries
    {
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
        public int SeriesId { get; set; }
        public virtual Series Series { get; set; }
    }
}