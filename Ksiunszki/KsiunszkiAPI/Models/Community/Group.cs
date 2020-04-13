using System.Collections.Generic;

namespace API.Models { 
    public class Group
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        private readonly List<User> _users;
        public IReadOnlyCollection<User> Users => _users;
    }
}