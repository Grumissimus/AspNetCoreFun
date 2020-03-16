﻿namespace KsiunszkiAPI.Entities
{
    public class BookTags
    {
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}