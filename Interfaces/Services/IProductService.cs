using CommunityProApp.Dtos;
using CommunityProApp.Models;
using System.Collections.Generic;

namespace CommunityProApp.Interfaces.Services
{
    public interface IProductService
    {
        BaseResponse AddProduct(CreateProductRequestModel model);
        BaseResponse UpdateProduct(int id, UpdateProductRequestModel model);
        ProductDto ProductDetail(int id);
        IList<ProductDto> GetProducts();
        IList<ProductDto> GetProductsByCategory(int categoryId);
        IList<ProductDto> SearchProducts(string searchText);

    }
}
