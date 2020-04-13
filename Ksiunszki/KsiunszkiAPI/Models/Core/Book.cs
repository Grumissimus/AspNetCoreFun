using System;

namespace API.Models
{
    public class Book
    {
        public int Id { get; private set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public short? NumberOfPages { get; set; }

        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
    }
}