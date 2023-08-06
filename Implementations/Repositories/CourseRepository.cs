using CommunityProApp.Context;
using CommunityProApp.Entities;
using CommunityProApp.Interfaces.Repositories;

namespace CommunityProApp.Implementations.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository( ApplicationContext context)
        {
            _context = context;
        }
    }
}
