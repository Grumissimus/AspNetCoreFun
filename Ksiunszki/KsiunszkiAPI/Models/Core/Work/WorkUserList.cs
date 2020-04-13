namespace API.Models
{
    public class WorkUserList
    {
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
        public int UserListId { get; set; }
        public virtual UserList UserList { get; set; }
    }
}