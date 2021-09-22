using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Services.Articles;
using Shop.EndPoint.Web.Ui.Models;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper mapper;
        private readonly IArticleService articleService;
        private readonly IArticleRepository articleRepository;

        public HomeController(ILogger<HomeController> logger, IMapper mapper
            , IArticleService articleService,IArticleRepository articleRepository)

        {
            _logger = logger;
            this.mapper = mapper;
            this.articleService = articleService;
            this.articleRepository = articleRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult About()
        {
            return View();
        }
        public IActionResult law()
        {
            return View();
        }
     
        public IActionResult Contact()
        {
            return View();
        }

   
        public IActionResult Article()
        {
            var Ariclelist = articleService.GetAll();

            List<ArticleViewModel> articleViewModel = new List<ArticleViewModel>();
            foreach (var item in Ariclelist.Data)
            {
                var ListArticle = mapper.Map<ArticleViewModel>(item);
                articleViewModel.Add(ListArticle);
            }

            if (Ariclelist.Data == null)
                return RedirectToAction("Error");

            return View(articleViewModel.Take(3));
        }



        public IActionResult DetailArticle(int id)
        {
            //repository
            var article = articleRepository.GetById(id);
            article.View += 1;
            //repository
            articleRepository.UpdateArticle(article);
            var Article = mapper.Map<ArticleViewModel>(article);
           
            if (Article == null)
                return RedirectToAction("Error");

            return View(Article);
        }


        public IActionResult Error()
        {
            return View();
        }

      

    }
}
