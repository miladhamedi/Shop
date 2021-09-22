using Microsoft.AspNetCore.Identity;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Role
{
    public interface IRoleService
    {
        Guid GetByRoleId(string rolename);
        List<RoleDto> GetAllRole();
        void AddRole(RoleDto roleDto);
        IdentityRole<Guid> GetById(Guid roleid);
        void RemoveRole(IdentityRole<Guid> identityRole);
        List<RoleDto> GetAllRoleUser(Guid userid);
        Guid GetByRoleName(string rolename);
    }
}
