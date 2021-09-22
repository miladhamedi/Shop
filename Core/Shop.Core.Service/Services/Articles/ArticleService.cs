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

namespace Shop.Core.Service.Services.Articles
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository articleRepository;
        private readonly IMapper mapper;

        public ArticleService(IArticleRepository articleRepository, IMapper mapper)
        {
            this.articleRepository = articleRepository;
            this.mapper = mapper;
        }
        public void AddArticle(ArticleDto article)
        {
            var articl = mapper.Map<Article>(article);
            articleRepository.AddArticle(articl);
        }

        public ShopActionResult<List<ArticleDto>> GetAll(int page = 1)
        {
            ShopActionResult<List<ArticleDto>> actionResult = new ShopActionResult<List<ArticleDto>>();
            actionResult.Page = page;
            actionResult.ItemCount = 3;
            var skip = (page - 1) * actionResult.ItemCount;
            var Lisrarticle = articleRepository.GetAll();
            actionResult.Counts = Lisrarticle.Count();
            var AllCount = Lisrarticle.Skip(skip).Take(actionResult.ItemCount);
            actionResult.Pages = Convert.ToInt32( Math.Ceiling((decimal)actionResult.Counts / actionResult.ItemCount));
            List<ArticleDto> articleDtos = new List<ArticleDto>();

            foreach (var item in AllCount)
            {
                var ListArticleDto = mapper.Map<ArticleDto>(item);
                articleDtos.Add(ListArticleDto);

            }
            actionResult.Data = articleDtos;
            return actionResult;



        }

        public ArticleDto GetById(int id)
        {
            var article = articleRepository.GetById(id);
            var Article = mapper.Map<ArticleDto>(article);
            return Article;
        }

        public void RemoveArticle(ArticleDto article)
        {
            var Article = mapper.Map<Article>(article);
            articleRepository.RemoveArticle(Article);
        }

        public void UpdateArticle(ArticleDto article)
        {
            var Article = mapper.Map<Article>(article);
            articleRepository.UpdateArticle(Article);
           
        }
    }
}
