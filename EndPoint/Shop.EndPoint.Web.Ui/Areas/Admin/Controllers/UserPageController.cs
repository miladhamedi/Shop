using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Common;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Role;
using Shop.Core.Service.Services.UserPages;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class UserPageController : BaseController
    {
        private readonly IUserPageService userPageService;
        private readonly IMapper mapper;
        private readonly IRoleService roleService;

        public UserPageController(IUserPageService userPageService
            , IMapper mapper, IRoleService roleService)
        {
            this.userPageService = userPageService;
            this.mapper = mapper;
            this.roleService = roleService;
        }

        public IActionResult Index(int page = 1)
        {
            var Appuser = User.Identity.Name;
            var UserPermission = userPageService.GetPermissionUser(Appuser, "Index", "UserPage");
            if (UserPermission.Count > 0)
            {
                ShopActionResult<List<UserPageViewModel>> actionResult = new ShopActionResult<List<UserPageViewModel>>();
                var listuserpage = userPageService.GetAll(page);
                actionResult.Pages = listuserpage.Pages;
                actionResult.Page = listuserpage.Page;
                List<UserPageViewModel> articleViewModels = new List<UserPageViewModel>();
                foreach (var item in listuserpage.Data)
                {
                    var userpage = mapper.Map<UserPageViewModel>(item);
                    articleViewModels.Add(userpage);
                }
                actionResult.Data = articleViewModels;


                return View(actionResult);
            }
            else
            {
                return RedirectToAction("NotAccessPage", "User");
            }
          
        }



        public IActionResult Create()
        {
            ViewBag.ListRole = new SelectList(roleService.GetAllRole(), "RoleId", "RoleName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserPageViewModel userPageViewModel)
        {
            if (ModelState.IsValid)
            {
                var userpage = mapper.Map<UserPageDto>(userPageViewModel);
                userPageService.AddUserPage(userpage);
                return RedirectToAction("Index");
            }
            return View(userPageViewModel);
        }


        public IActionResult Edit(int userpageid)
        {
            var Userpage = userPageService.GetById(userpageid);
            var userpage = mapper.Map<UserPageViewModel>(Userpage);
            ViewBag.ListRole = new SelectList(roleService.GetAllRole(), "RoleId", "RoleName", userpage.RoleId);
            return View(userpage);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UserPageViewModel userPageViewModel)
        {
            if (ModelState.IsValid)
            {
                var userpage = mapper.Map<UserPageDto>(userPageViewModel);
                userPageService.UpdateUserPage(userpage);
                return RedirectToAction("Index");
            }
            ViewBag.ListRole = new SelectList(roleService.GetAllRole(), "RoleId", "RoleName", userPageViewModel.RoleId);
            return View(userPageViewModel);
        }




        public IActionResult Delete(int userpageid)
        {

            var Userpage = userPageService.GetById(userpageid);
            userPageService.RemoveUserPage(Userpage);

            return RedirectToAction("Index");
        }
    }
}
