using Shop.Common;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Articles
{
    public interface IArticleService
    {
        ShopActionResult<List<ArticleDto>> GetAll(int page = 1);
        ArticleDto GetById(int id);
        void UpdateArticle(ArticleDto article);
        void AddArticle(ArticleDto article);
        void RemoveArticle(ArticleDto article);
    }
}
