using CommunityProApp.Context;
using CommunityProApp.Entities;
using CommunityProApp.Interfaces.Repositories;

namespace CommunityProApp.Implementations.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>,  IDepartmentRepository
    {
        public DepartmentRepository( ApplicationContext context)
        {
            _context = context;
        }
    }
}
