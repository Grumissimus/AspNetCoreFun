using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KsiunszkiAPI.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? ReleaseDate { get; set; }
        public string OriginalTitle { get; set; }
        public int NumberOfPages { get; set; }
        public string Language { get; set; }
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        public int? ParentId { get; set; }
        public virtual Book Parent { get; set; }
        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }
        public virtual ICollection<BookLists> BookLists { get; set; }
        public virtual ICollection<BookSeries> BookSeries { get; set; }
        public virtual ICollection<BookTags> BookTags { get; set; }
    }
}