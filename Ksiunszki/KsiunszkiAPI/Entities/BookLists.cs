namespace KsiunszkiAPI.Entities
{
    public class BookLists
    {
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int ListId { get; set; }
        public virtual Series List { get; set; }
    }
}