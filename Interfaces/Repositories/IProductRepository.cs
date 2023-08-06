using CommunityProApp.Dtos;
using CommunityProApp.Entities;
using System.Collections.Generic;

namespace CommunityProApp.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IList<Product> GetProductsByCategory(int categoryId);

        IList<ProductDto> Search(string searchText);
    }
}
