using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KsiunszkiAPI.Entities
{
    public class List
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<BookLists> BookLists { get; set; }
    }
}
