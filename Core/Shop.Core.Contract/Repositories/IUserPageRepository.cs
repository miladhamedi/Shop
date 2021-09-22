using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Contract.Repositories
{
    public interface IUserPageRepository
    {
        List<UserPage> GetAll();
        void AddUserPage(UserPage userPage);
        void UpdateUserPage(UserPage userPage);
        void RemoveUserPage(UserPage userPage);
        UserPage GetById(int userpageid);
        UserPage GetUserByRole(Guid role, string actionname, string controllername);
    }
}
