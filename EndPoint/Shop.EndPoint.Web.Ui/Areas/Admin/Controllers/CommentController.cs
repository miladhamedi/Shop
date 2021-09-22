using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Services.Comments;
using Shop.Core.Service.ServiceSender;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class CommentController : BaseController
    {
        private readonly ICommentService commentService;
        private readonly ICommentRepository commentRepository;
        private readonly IMapper mapper;
      

        public CommentController(ICommentService commentService,
            ICommentRepository commentRepository,IMapper mapper)
        {
            this.commentService = commentService;
            this.commentRepository = commentRepository;
            this.mapper = mapper;
         
        }

        public IActionResult Index(int page = 1)
        {

            ShopActionResult<List<CommentViewModel>> actionResult = new ShopActionResult<List<CommentViewModel>>();
            var ListComment = commentService.GetAll(page);
            actionResult.Pages = ListComment.Pages;
            actionResult.Page = ListComment.Page;
            List<CommentViewModel> commentViewModels = new List<CommentViewModel>();
            foreach (var item in ListComment.Data)
            {
                var article = mapper.Map<CommentViewModel>(item);
                commentViewModels.Add(article);
            }
            actionResult.Data = commentViewModels;


            return View(actionResult);
        }


        public IActionResult Details(int id)
        {

            var comment = commentService.GetCommentById(id);
            if (comment == null)
            {
                return View("Error", "Home");
            }
            var Comment = mapper.Map<CommentViewModel>(comment);

            return View(Comment);
        }


        public IActionResult Edit(int id)
        {
            var comment = commentService.GetCommentById(id);
            if (comment == null)
            {
                return View("Error","Home");
            }

            var Comment = mapper.Map<CommentViewModel>(comment);


            return View(Comment);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CommentViewModel model)
        {
           
            var comment = commentService.GetCommentById(model.CommentId);

            if (comment == null)
                return RedirectToAction("Erorr", "Home");

            comment.Confirm = true;
           
            commentService.UpdateComment(comment);
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            var comment = commentService.GetCommentById(id);
            if (comment == null)
            {
                return RedirectToAction("Erorr", "Home");
            }

            commentService.DeleteComment(comment);

            return RedirectToAction("Index");
        }

       

    }
}
