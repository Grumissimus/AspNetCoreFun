namespace API.Models
{
    public class CharacterWork
    {
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
    }
}