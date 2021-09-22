using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface IRoleRepository
    {
        IdentityRole<Guid> GetByRoleAdmin(string rolename = "Admin");
        IdentityRole<Guid> GetByUserRoleId(string rolename = "User");
        Guid GetByRoleId(string rolename);
        IdentityRole<Guid> GetById(Guid roleid);
        List<IdentityRole<Guid>> GetAllRole();
        void AddRole(IdentityRole<Guid> identityRole);
        void RemoveRole(IdentityRole<Guid> identityRole);
        Guid GetByRoleName(string rolename);

       
    }
}
