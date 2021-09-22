using Shop.Common;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Categories
{
    public interface ICategoryService
    {
        ShopActionResult<List<CategoryDto>> GetAll(int page = 1);
        CategoryDto GetById(int categoryid);
        void AddCategory(CategoryDto categoryDto);
        void UpdateCategory(CategoryDto categoryDto);
        List<CategoryDto> GetAllCategory();
    }
}
