using CommunityProApp.Entities;
using System.Collections.Generic;

namespace CommunityProApp.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public IEnumerable<Category> GetSelected(IList<int> ids);
    }
}
