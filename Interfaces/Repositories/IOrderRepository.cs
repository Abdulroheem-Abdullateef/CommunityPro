using CommunityProApp.Dtos;
using CommunityProApp.Entities;
using System.Collections.Generic;

namespace CommunityProApp.Interfaces.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
         public IList<OrderDto> Search(string searchText);
    }
}
