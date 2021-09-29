using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ShopDbContext shopDbContext;

        public CategoryRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public void AddCategory(Category category)
        {
            shopDbContext.Categories.Add(category);
            shopDbContext.SaveChanges();
        }

        public bool ExsistCategory(int categoryid)
        {
            var Category = shopDbContext.Categories.Any(c => c.CategoryId == categoryid);
            return Category;
        }

        public List<Category> GetAll()
        {
            var categorylist = shopDbContext.Categories.Where(c => c.ActivePassive == true).ToList();
            return categorylist;
        }

        public Category GetById(int categoryid)
        {
            var Category = shopDbContext.Categories.Where(c=>c.CategoryId == categoryid).AsNoTracking().FirstOrDefault();
            return Category;

        }

        public Category GetCategory(int? id, string titel)
        {
            var category = shopDbContext.Categories
                .Where(c => c.CategoryId.Equals(id) && c.Titel.Equals(titel)).FirstOrDefault();
            return category;
        }

        public void UpdateCategory(Category category)
        {
            shopDbContext.Categories.Attach(category);
            shopDbContext.Entry(category).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }
    }
}
