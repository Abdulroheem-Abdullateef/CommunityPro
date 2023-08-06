using CommunityProApp.Context;
using CommunityProApp.Entities;
using CommunityProApp.Interfaces.Repositories;

namespace CommunityProApp.Implementations.Repositories
{
    public class BookLendingRepository : BaseRepository<BookLending>, IBookLendingRepository
    {
        public BookLendingRepository(ApplicationContext context)
        {
            _context = context;
        }
    }
}
