﻿namespace KsiunszkiAPI.Entities
{
    public class BookSeries
    {
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int SeriesId { get; set; }
        public virtual Series Series { get; set; }
        public int Order { get; set; }
    }
}