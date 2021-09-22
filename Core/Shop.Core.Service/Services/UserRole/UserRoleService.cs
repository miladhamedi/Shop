using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.UserRole
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUserRoleRepository userRoleRepository;
        private readonly IRoleRepository roleRepository;


        public UserRoleService(IUserRoleRepository userRoleRepository, IRoleRepository roleRepository)
        {
            this.userRoleRepository = userRoleRepository;
            this.roleRepository = roleRepository;

        }

        public void AddRole(IdentityUserRole<Guid> identityUserRole)
        {
            userRoleRepository.AddRole(identityUserRole);
        }

        public void AddUserRole(Guid userid)
        {
            userRoleRepository.AddUserRole(userid);
        }

        public void AddUserRoleAdmin(Guid userid, Guid roleid)
        {
            userRoleRepository.AddUserRoleAdmin(userid, roleid);
        }

        public IdentityUserRole<Guid> GetByAdminRole()
        {
            var userrole = roleRepository.GetByRoleAdmin();
            var userRole = userRoleRepository.GetByUserRole(userrole.Id);
            return userRole;
        }

        public IdentityUserRole<Guid> GetByUserRole()
        {
            var userrole = roleRepository.GetByUserRoleId();
            var userRole = userRoleRepository.GetByUserRole(userrole.Id);
            return userRole;
        }

        public IdentityUserRole<Guid> GetRoleId(Guid roleid)
        {
            var userrole = userRoleRepository.GetByUserRole(roleid);
            return userrole;
        }

        public void RemoveUserRole(IdentityUserRole<Guid> identityUserRole)
        {
            userRoleRepository.RemoveUserRole(identityUserRole);
        }
    }
}
