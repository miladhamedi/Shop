using Shop.Common;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.UserPages
{
    public interface IUserPageService
    {
        ShopActionResult<List<UserPageDto>> GetAll(int page = 1);
        void AddUserPage(UserPageDto userPage);
        void UpdateUserPage(UserPageDto userPage);
        void RemoveUserPage(UserPageDto userPage);
        UserPageDto GetById(int userpageid);
        List<UserPageDto> GetPermissionUser(string username, string actionname, string controllername);
    }
}
