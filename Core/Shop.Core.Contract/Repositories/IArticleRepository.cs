using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface IArticleRepository
    {
        List<Article> GetAll();
        Article GetById(int id);
        void UpdateArticle(Article article);
        void AddArticle(Article article);
        void RemoveArticle(Article article);
        List<Article> GetAllArticle();
      
    }
}
