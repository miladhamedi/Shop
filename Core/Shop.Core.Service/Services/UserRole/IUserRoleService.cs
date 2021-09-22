using Microsoft.AspNetCore.Identity;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.UserRole
{
    public interface IUserRoleService
    {

        void AddUserRole(Guid userid);
        void AddUserRoleAdmin(Guid userid, Guid roleid);
        IdentityUserRole<Guid> GetByUserRole();
        IdentityUserRole<Guid> GetByAdminRole();
        void AddRole(IdentityUserRole<Guid> identityUserRole);
        IdentityUserRole<Guid> GetRoleId(Guid roleid);
        void RemoveUserRole(IdentityUserRole<Guid> identityUserRole);

    }
}
