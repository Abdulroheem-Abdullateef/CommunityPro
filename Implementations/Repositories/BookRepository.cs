using CommunityProApp.Context;
using CommunityProApp.Entities;
using CommunityProApp.Interfaces.Repositories;

namespace CommunityProApp.Implementations.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationContext context)
        {
            _context = context;
        }
    }
}
