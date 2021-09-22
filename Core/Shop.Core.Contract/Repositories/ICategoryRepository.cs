using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface ICategoryRepository
    {
        Category GetCategory(int? id , string titel);
        List<Category> GetAll();
        Category GetById(int categoryid);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        bool ExsistCategory(int categoryid);
    }
}
