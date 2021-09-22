using Shop.Common;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.User
{
    public interface IUserService
    {
        string GetEmailUser(Guid userid);
        void AddInformationUser(UserDto userDto);
        bool checkValueUser(string username);
        UserDto GetByUserName(string username);
        void UpdatedUser(UserDto userDto);
        PostInformationDto PostInFormationUser(string username);
        UserDto GetByUserId(Guid userid);
        string CheckRoleUser(string username);
        ShopActionResult<List<UserDto>> GetAllUser(int page = 1);
    }
}
