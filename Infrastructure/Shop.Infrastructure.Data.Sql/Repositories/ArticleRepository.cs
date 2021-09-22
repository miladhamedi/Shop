using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ShopDbContext shopDbContext;

        public ArticleRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public void AddArticle(Article article)
        {
            shopDbContext.Articles.Add(article);
            shopDbContext.SaveChanges();
        }

       
        public List<Article> GetAll()
        {
            var Listarticle = shopDbContext.Articles.OrderByDescending(c => c.Date).AsNoTracking().ToList();
            return Listarticle;
        }

        public List<Article> GetAllArticle()
        {
            var Listarticle = shopDbContext.Articles.AsNoTracking().ToList();
            return Listarticle;
        }

        public Article GetById(int id)
        {
            var article = shopDbContext.Articles.Where(c => c.ArticleId == id).SingleOrDefault();
            return article;
        }

        public void RemoveArticle(Article article)
        {
            shopDbContext.Articles.Remove(article);
            shopDbContext.SaveChanges();
        }

        public void UpdateArticle(Article article)
        {
            shopDbContext.Articles.Attach(article);
            shopDbContext.Entry(article).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }
    }
}
