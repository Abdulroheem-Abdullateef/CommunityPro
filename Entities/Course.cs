using System.Collections.Generic;

namespace CommunityProApp.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}
