using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Contract.Repositories
{
    public interface IUserRoleRepository
    {
        void AddUserRole(Guid userid);
        void AddRole(IdentityUserRole<Guid> identityUserRole);
        IdentityUserRole<Guid> GetByUserRole(Guid roleid);
        List<IdentityUserRole<Guid>> GetRoleUser(Guid userid);
        void AddUserRoleAdmin(Guid userid,Guid roleid);
        void RemoveUserRole(IdentityUserRole<Guid> identityUserRole);
    }
}
