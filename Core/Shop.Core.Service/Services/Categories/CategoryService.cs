using AutoMapper;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryService(ICategoryRepository categoryRepository,IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public void AddCategory(CategoryDto categoryDto)
        {
            var category = mapper.Map<Category>(categoryDto);
            categoryRepository.AddCategory(category);
        }

        public ShopActionResult<List<CategoryDto>> GetAll(int page = 1)
        {
            ShopActionResult<List<CategoryDto>> actionResult = new ShopActionResult<List<CategoryDto>>();
            actionResult.Page = page;
            actionResult.ItemCount = 6;
            var skip = (page - 1) * actionResult.ItemCount;
            var ListCategory = categoryRepository.GetAll();
            actionResult.Counts = ListCategory.Count();
            var AllCount = ListCategory.Skip(skip).Take(actionResult.ItemCount);
            actionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)actionResult.Counts / actionResult.ItemCount));
            List<CategoryDto> categoryDtos = new List<CategoryDto>();

            foreach (var item in AllCount)
            {
                var Listcategory = mapper.Map<CategoryDto>(item);
                categoryDtos.Add(Listcategory);

            }
            actionResult.Data = categoryDtos;
            return actionResult;
        }

        public List<CategoryDto> GetAllCategory()
        {
            var ListCategory = categoryRepository.GetAll();
            List<CategoryDto> categoryDtos = new List<CategoryDto>();
            foreach (var item in ListCategory)
            {
                var Listcategory = mapper.Map<CategoryDto>(item);
                categoryDtos.Add(Listcategory);

            }
            return categoryDtos;
        }

        public CategoryDto GetById(int categoryid)
        {
            var category = categoryRepository.GetById(categoryid);
            var Category = mapper.Map<CategoryDto>(category);
            return Category;
        }

        public void UpdateCategory(CategoryDto categoryDto)
        {
            var category = mapper.Map<Category>(categoryDto);
            categoryRepository.UpdateCategory(category);
        }
    }
}
