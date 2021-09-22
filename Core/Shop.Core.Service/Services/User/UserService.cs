using AutoMapper;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.UserRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepositroy userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepositroy userRepository
            ,IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public void AddInformationUser(UserDto userdto)
        {
            var user = mapper.Map<ApplicationUser>(userdto);
            userRepository.AddInformationUser(user);
        }

        public string CheckRoleUser(string username)
        {
           var Role = userRepository.CheckRoleUser(username);
            return Role;
        }

        public bool checkValueUser(string username)
        {
          var user =  userRepository.checkValueUser(username);

            return user;
        }

        public ShopActionResult<List<UserDto>> GetAllUser(int page = 1)
        {
            ShopActionResult<List<UserDto>> actionResult = new ShopActionResult<List<UserDto>>();
            actionResult.Page = page;
            actionResult.ItemCount = 3;
            var skip = (page - 1) * actionResult.ItemCount;
            var ListUser = userRepository.GetAllUser();
            actionResult.Counts = ListUser.Count();
            var UserPage = ListUser.Skip(skip).Take(actionResult.ItemCount);
            actionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)actionResult.Counts / actionResult.ItemCount));
            List<UserDto> userdto = new List<UserDto>();
           
            foreach (var item in UserPage)
            {
                var user = mapper.Map<UserDto>(item);
                userdto.Add(user);
            }
            actionResult.Data = userdto;
            return actionResult;
        }

        public UserDto GetByUserId(Guid userid)
        {
            var user = userRepository.GetByUserId(userid);
            var User = mapper.Map<UserDto>(user);
            return User;
        }

        public UserDto GetByUserName(string username)
        {
            var user = userRepository.GetByUserName(username);
            var User = mapper.Map<UserDto>(user);
            return User;
        }

        public string GetEmailUser(Guid userid)
        {
            var userEmail = userRepository.GetEmailUser(userid);
            return userEmail;
        }

        public PostInformationDto PostInFormationUser(string username)
        {
            var user = userRepository.GetByUserName(username);
            var User = mapper.Map<PostInformationDto>(user);
            return User;
        }

        public void UpdatedUser(UserDto userdto)
        {
            var user = mapper.Map<ApplicationUser>(userdto);
            userRepository.UpdatedUser(user);
        }
    }
}
