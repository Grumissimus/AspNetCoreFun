using Newtonsoft.Json;

namespace API.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        [JsonIgnore]
        public virtual Genre Parent { get; set; }
    }
}