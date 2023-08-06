using CommunityProApp.Dtos;
using CommunityProApp.Models;
using System.Collections.Generic;

namespace CommunityProApp.Interfaces.Services
{
    public interface ICategoryService
    {
        BaseResponse AddCategory(CreateCategoryRequestModel model);
        BaseResponse UpdateCategory(int id, UpdateCategoryRequestModel model);
        CategoryDto GetCategory(int id);
        IList<CategoryDto> GetCategories();

    }
}
