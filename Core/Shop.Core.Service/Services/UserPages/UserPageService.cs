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

namespace Shop.Core.Service.Services.UserPages
{
    public class UserPageService : IUserPageService
    {
        private readonly IUserPageRepository userPageRepository;
        private readonly IMapper mapper;
        private readonly IUserRepositroy userRepositroy;
        private readonly IUserRoleRepository userRoleRepository;

        public UserPageService(IUserPageRepository userPageRepository
            ,IMapper mapper,IUserRepositroy userRepositroy,
            IUserRoleRepository userRoleRepository)
        {
            this.userPageRepository = userPageRepository;
            this.mapper = mapper;
            this.userRepositroy = userRepositroy;
            this.userRoleRepository = userRoleRepository;
        }
        public void AddUserPage(UserPageDto userPage)
        {
            var userpage = mapper.Map<UserPage>(userPage);
            userPageRepository.AddUserPage(userpage);
        }

        public ShopActionResult<List<UserPageDto>> GetAll(int page = 1)
        {
            ShopActionResult<List<UserPageDto>> actionResult = new ShopActionResult<List<UserPageDto>>();
            actionResult.Page = page;
            actionResult.ItemCount =5;
            var skip = (page - 1) * actionResult.ItemCount;
            var listuserpage = userPageRepository.GetAll();
            actionResult.Counts = listuserpage.Count();
            var AllCount = listuserpage.Skip(skip).Take(actionResult.ItemCount);
            actionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)actionResult.Counts / actionResult.ItemCount));
            List<UserPageDto> userPageDtos = new List<UserPageDto>();

            foreach (var item in AllCount)
            {
                var userlist = mapper.Map<UserPageDto>(item);
                userPageDtos.Add(userlist);

            }
            actionResult.Data = userPageDtos;
            return actionResult;
        }

        public UserPageDto GetById(int userpageid)
        {
            var userpa = userPageRepository.GetById(userpageid);
            var userpage = mapper.Map<UserPageDto>(userpa);
            return userpage;
        }

        public List<UserPageDto> GetPermissionUser(string username,string actionname,string controllername)
        {
            List<UserPageDto> userPageDtos = new List<UserPageDto>();
            var User = userRepositroy.GetByUserName(username);
            var userRole = userRoleRepository.GetRoleUser(User.Id);
            foreach (var item in userRole)
            {
                var userPage = userPageRepository.GetUserByRole(item.RoleId, actionname, controllername);

                var UserPage = mapper.Map<UserPageDto>(userPage);
                if (UserPage != null)
                {
                    userPageDtos.Add(UserPage);
                    return userPageDtos;
                }
              
            }

            return userPageDtos;

        }

        public void RemoveUserPage(UserPageDto userPage)
        {
            var userpage = mapper.Map<UserPage>(userPage);
            userPageRepository.RemoveUserPage(userpage);
        }

        public void UpdateUserPage(UserPageDto userPage)
        {
            var userpage = mapper.Map<UserPage>(userPage);
            userPageRepository.UpdateUserPage(userpage);
        }
    }
}
