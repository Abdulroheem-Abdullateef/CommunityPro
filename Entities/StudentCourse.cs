namespace CommunityProApp.Entities
{
    public class StudentCourse : BaseEntity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public double Score { get; set; }
        public string Grade { get; set; }
    }
}
