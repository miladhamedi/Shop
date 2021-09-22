using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Articles;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class ArticleController : BaseController
    {
        private readonly IArticleService articleService;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IArticleRepository articleRepository;

        public ArticleController(IArticleService articleService,
            IMapper mapper, IWebHostEnvironment webHostEnvironment,IArticleRepository articleRepository)
        {
            this.articleService = articleService;
            this.mapper = mapper;
            this.webHostEnvironment = webHostEnvironment;
            this.articleRepository = articleRepository;
        }
        public IActionResult Index(int page = 1)
        {
            ShopActionResult<List<ArticleViewModel>> actionResult = new ShopActionResult<List<ArticleViewModel>>();
            var ListArticle = articleService.GetAll(page);
            actionResult.Pages = ListArticle.Pages;
            actionResult.Page = ListArticle.Page;
            List<ArticleViewModel> articleViewModels = new List<ArticleViewModel>();
            foreach (var item in ListArticle.Data)
            {
                var article = mapper.Map<ArticleViewModel>(item);
                articleViewModels.Add(article);
            }
            actionResult.Data = articleViewModels;


            return View(actionResult);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ArticleViewModel model, IFormFile Image)
        {

            if (ModelState.IsValid)
            {
                if (!Directory.Exists(@"" + webHostEnvironment.WebRootPath + "/uploads/article/"))
                {
                    Directory.CreateDirectory(@"" + webHostEnvironment.WebRootPath + "/uploads/article/");
                }
                var uploads = Path.Combine(webHostEnvironment.WebRootPath, "uploads\\article");
                if (Image.Length > 0)
                {
                    string FileName = "Article-" + DateTime.Now.Second * 2 + "." + Image.FileName.Split('.').Last();
                    using (var fileStream = new FileStream(Path.Combine(uploads, FileName), FileMode.Create))
                    {
                        Image.CopyTo(fileStream);
                    }

                    ArticleDto article = new ArticleDto();

                    article.Date = DateTime.Now;
                    article.Description = model.Description;
                    article.Image = FileName;
                    article.Text = model.Text;
                    article.Titel = model.Titel;
                    article.View = 0;

                    articleService.AddArticle(article);

                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            return View(model);
        }


        public IActionResult Edit(int articleid)
        {
            var article = articleService.GetById(articleid);
            if (article == null)
                return null;
            var Article = mapper.Map<ArticleViewModel>(article);

            return View(Article);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(IFormFile Image, ArticleViewModel articleViewModel)
        {
            //repository
            var article = articleRepository.GetById(articleViewModel.ArticleId);
            try
            {
                if (Image != null)
                {
                    var uploads = Path.Combine(webHostEnvironment.WebRootPath, "uploads\\article");
                    var RoutFile = Path.Combine(webHostEnvironment.WebRootPath, "uploads\\article\\" + article.Image);

                    if (System.IO.File.Exists(RoutFile))
                    {
                        System.IO.File.Delete(RoutFile);
                    }

                    Random rnd = new Random();

                    string FileName = "ArticleUpdate-" + rnd.Next(1, 9999) + DateTime.Now.Second * 32 + "." + Image.FileName.Split('.').Last();
                    using (var fileStream = new FileStream(Path.Combine(uploads, FileName), FileMode.Create))
                    {
                        Image.CopyTo(fileStream);
                    }

                    article.Description = articleViewModel.Description;
                    article.Image = FileName;
                    article.Text = articleViewModel.Text;
                    article.Titel = articleViewModel.Titel;

                    //repository
                    articleRepository.UpdateArticle(article);
                    return RedirectToAction("Index");
                }
                else
                {
                    article.Description = articleViewModel.Description;
                    article.Text = articleViewModel.Text;
                    article.Titel = articleViewModel.Titel;

                    //repository
                    articleRepository.UpdateArticle(article);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }

        }
        
        public IActionResult Delete(int articleid)
        {
            //localuploadfile
            //repository
            var article = articleRepository.GetById(articleid);
            var RoutFile = Path.Combine(webHostEnvironment.WebRootPath, "uploads\\article\\" + article.Image);

            if (System.IO.File.Exists(RoutFile))
            {
                System.IO.File.Delete(RoutFile);
            }
            //repository
            articleRepository.RemoveArticle(article);
            return RedirectToAction("Index");
        }
    }
}
