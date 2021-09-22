using Microsoft.AspNetCore.Identity;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface IUserRepositroy
    {

        string GetEmailUser(Guid userid);
        void AddInformationUser(ApplicationUser applicationUser);
        bool checkValueUser(string username);
        ApplicationUser GetByUserName(string username);
        ApplicationUser GetByUserId(Guid userid);
        void UpdatedUser(ApplicationUser applicationUser);
        string CheckRoleUser(string username);
        List<ApplicationUser> GetAllUser();
        List<ApplicationUser> GetLastUser();




    }
}
