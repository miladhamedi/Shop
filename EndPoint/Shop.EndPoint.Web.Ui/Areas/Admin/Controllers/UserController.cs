using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Role;
using Shop.Core.Service.Services.User;
using Shop.Core.Service.Services.UserPages;
using Shop.Core.Service.Services.UserRole;
using Shop.EndPoint.Web.Ui.Areas.Admin.ViewModel;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;
        private readonly IRoleService roleService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IUserRoleService userRoleService;
        private readonly IUserPageService userPageService;

        public UserController(IUserService userService, IMapper mapper,
             IRoleService roleService, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, IUserRoleService userRoleService,IUserPageService userPageService)
        {
            this.userService = userService;
            this.mapper = mapper;
            this.roleService = roleService;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userRoleService = userRoleService;
            this.userPageService = userPageService;
        }
        public IActionResult Index(int page = 1)
        {
            var Appuser = User.Identity.Name;
            var UserPermission = userPageService.GetPermissionUser(Appuser, "Index", "User");
            if (UserPermission.Count > 0 )
            {
                ShopActionResult<List<UserViewModel>> actionResult = new ShopActionResult<List<UserViewModel>>();
                var ListUser = userService.GetAllUser();
                actionResult.Page = page;
                actionResult.Pages = ListUser.Pages;
                List<UserViewModel> userViewModels = new List<UserViewModel>();
                foreach (var item in ListUser.Data)
                {
                    var user = mapper.Map<UserViewModel>(item);
                    userViewModels.Add(user);
                }
                actionResult.Data = userViewModels;
                return View(actionResult);
            }
            else
            {
                return RedirectToAction("NotAccessPage","User");
            }
           
        }


        public IActionResult NotAccessPage()
        {
            return View();
        }

        public IActionResult Active(Guid userid)
        {

            var user = userService.GetByUserId(userid);
            if (user == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            user.Access = true;
            userService.UpdatedUser(user);
            return RedirectToAction("Index");
        }


        public IActionResult InActive(Guid userid)
        {

            var user = userService.GetByUserId(userid);
            if (user == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            user.Access = false;
            userService.UpdatedUser(user);
            return RedirectToAction("Index");
        }

        public IActionResult Details(Guid userid)
        {
            var user = userService.GetByUserId(userid);
            if (user == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            UserViewModel userViewModel = new UserViewModel();

            userViewModel.PhoneNumber = user.PhoneNumber;
            userViewModel.NameFamily = user.NameFamily;
            userViewModel.Email = user.Email;
            userViewModel.City = user.City;
            userViewModel.Address = user.Address;
            userViewModel.Province = user.Province;
            userViewModel.UserName = user.UserName;
            userViewModel.PostalCode = user.PostalCode;

            return View(userViewModel);
        }




        public IActionResult ListRole(Guid userid)
        {
            var user = userService.GetByUserId(userid);
            if (user == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            var listRole = roleService.GetAllRoleUser(user.Id);
            List<RoleViewModel> roleViewModels = new List<RoleViewModel>();
            foreach (var item in listRole)
            {
                var role = mapper.Map<RoleViewModel>(item);
                roleViewModels.Add(role);
            }
            ViewBag.UserId = user.Id;
            return View(roleViewModels);
        }



        public IActionResult RemoveRole(string rolename)
        {
            var roleid = roleService.GetByRoleName(rolename);
            var Userrole = userRoleService.GetRoleId(roleid);
            if (Userrole == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            userRoleService.RemoveUserRole(Userrole);
            return RedirectToAction("ListRole", new { userid = Userrole.UserId });
        }



        public IActionResult AddRole(Guid userid)
        {
            ViewBag.UserId = userid;
            ViewBag.ListRole = new SelectList(roleService.GetAllRole(), "RoleId", "RoleName");
            return View();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddRole(UserRoleViewModel model)
        {
            if (ModelState.IsValid)
            {

                IdentityUserRole<Guid> identityUserRole = new IdentityUserRole<Guid>();
                identityUserRole.UserId = model.UserId;
                identityUserRole.RoleId = model.RoleId;

                userRoleService.AddRole(identityUserRole);

                return RedirectToAction("ListRole", new { userid = model.UserId });


            }

            return RedirectToAction("AddRole", new { userid = model.UserId });

        }
    }
}