using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace KsiunszkiAPI.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Genre Parent { get; set; }
    }
}