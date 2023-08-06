using CommunityProApp.Context;
using CommunityProApp.Entities;
using CommunityProApp.Interfaces.Repositories;

namespace CommunityProApp.Implementations.Repositories
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository( ApplicationContext context)
        {
            _context = context;
        }
    }
}
