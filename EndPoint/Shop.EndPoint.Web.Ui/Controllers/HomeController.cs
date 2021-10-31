using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto.IndexDto;
using Shop.Core.Service.Services.Articles;
using Shop.Core.Service.Services.Messages;
using Shop.Core.Service.Services.User;
using Shop.Core.Service.Services.UserRole;
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
        private readonly IUserService userService;
        private readonly IUserRoleService userRoleService;
        private readonly IMessageService messageService;

        public HomeController(ILogger<HomeController> logger, IMapper mapper
            , IArticleService articleService,IUserService userService,
            IUserRoleService userRoleService,IMessageService messageService)

        {
            _logger = logger;
            this.mapper = mapper;
            this.articleService = articleService;
            this.userService = userService;
            this.userRoleService = userRoleService;
            this.messageService = messageService;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = userService.GetByUserName(model.Email);
                if (user.Email == model.Email && user.EmailConfirmed == true)
                {
                    var AdminRole = userRoleService.GetByAdminRole();
                    MessageDto messageDto = new MessageDto();
                    messageDto.Confirm = false;
                    messageDto.Text = model.Text;
                    messageDto.UserIdSend = user.Id;
                    messageDto.UserIdRecive = AdminRole.UserId;
                    messageDto.Date = DateTime.Now;
                    messageService.AddMessage(messageDto);
                    ViewBag.Message = "پیام ارسال شد پاسخ شما ب پروفایل من قسمت پیام های من ارسال خواهد شد";
                    ViewBag.Status = true;
                    return View();
                }
                else
                {
                    ViewBag.Message = "لطفا ثبت نام کنید";
                    ViewBag.Status = false;
                    return View();
                }
            }

            ViewBag.Message = "مقادیر را ب درستی  پر کنید";
            ViewBag.Status = false;

            return View(model);
          
        }


        public IActionResult Article()
        {
            var Ariclelist = articleService.GetAll();
            if (Ariclelist.Data.Count == 0)
            {
                return RedirectToAction("Error");
            }

            List<ArticleViewModel> articleViewModel = new List<ArticleViewModel>();
            foreach (var item in Ariclelist.Data)
            {
                var ListArticle = mapper.Map<ArticleViewModel>(item);
                articleViewModel.Add(ListArticle);
            }

         

            return View(articleViewModel.Take(3));
        }



        public IActionResult DetailArticle(int id)
        {
            var article = articleService.DetailArticle(id);
            if (article == null)
            {
                return RedirectToAction("Error");

            }
            var Article = mapper.Map<ArticleViewModel>(article);

            if (Article != null)
                return RedirectToAction("Error");

            return View(Article);
        }


        public IActionResult Error()
        {
            return View();
        }



    }
}
