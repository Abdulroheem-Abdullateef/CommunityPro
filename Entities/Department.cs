using System.Collections.Generic;

namespace CommunityProApp.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
