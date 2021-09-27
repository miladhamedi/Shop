using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Role;
using Shop.Core.Service.Services.UserPages;
using Shop.EndPoint.Web.Ui.Areas.Admin.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class RolesController : BaseController
    {
        private readonly IRoleService roleService;
        private readonly IMapper mapper;
        private readonly IUserPageService userPageService;

        public RolesController(IRoleService roleService,
            IMapper mapper,IUserPageService userPageService)
        {
            this.roleService = roleService;
            this.mapper = mapper;
            this.userPageService = userPageService;
        }
        public IActionResult Index()
        {
            var Appuser = User.Identity.Name;
            var UserPermission = userPageService.GetPermissionUser(Appuser, "Index", "Roles");
            if (UserPermission.Count > 0)
            {
                List<RoleViewModel> roleViewModels = new List<RoleViewModel>();
                var ListRole = roleService.GetAllRole();
                foreach (var item in ListRole)
                {
                    var role = mapper.Map<RoleViewModel>(item);
                    roleViewModels.Add(role);
                }

                return View(roleViewModels);
            }
            else
            {
                return RedirectToAction("NotAccessPage", "User");
            }

          
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                RoleDto roleDto = new RoleDto();
                roleDto.RoleName = model.RoleName;
                roleService.AddRole(roleDto);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(Guid roleid)
        {
            var role = roleService.GetById(roleid);
            if (role == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            roleService.RemoveRole(role);
            return RedirectToAction("Index");


        }


    }
}
