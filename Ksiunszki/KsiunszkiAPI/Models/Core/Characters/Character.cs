using System.Collections.Generic;

namespace API.Models
{
    public class Character
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<CharacterWork> Works { get; set; }
    }
}