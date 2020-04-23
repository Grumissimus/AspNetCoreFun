using System.Collections.Generic;

namespace API.Models
{
    public class UserList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<WorkUserList> Works { get; set; }
    }
}