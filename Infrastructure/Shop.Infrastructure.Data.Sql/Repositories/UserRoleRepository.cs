using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ShopDbContext shopDbContext;
        private readonly IRoleRepository roleRepository;

        public UserRoleRepository(ShopDbContext shopDbContext,IRoleRepository roleRepository)
        {
            this.shopDbContext = shopDbContext;
            this.roleRepository = roleRepository;
        }

        public void AddRole(IdentityUserRole<Guid> identityUserRole)
        {
            shopDbContext.UserRoles.Add(identityUserRole);
            shopDbContext.SaveChanges();
        }

        public void AddUserRole(Guid userid)
        {
           var roleid = roleRepository.GetByUserRoleId();
            shopDbContext.UserRoles.Add(new IdentityUserRole<Guid>()
            {
                RoleId = roleid.Id,
                UserId = userid

            });

            shopDbContext.SaveChanges();
        }

        public void AddUserRoleAdmin(Guid userid, Guid roleid)
        {
            shopDbContext.UserRoles.Add(new IdentityUserRole<Guid>()
            {
                RoleId = roleid,
                UserId = userid

            });
            shopDbContext.SaveChanges();
        }


        public IdentityUserRole<Guid> GetByUserRole(Guid roleid)
        {
          
            var UserRole = shopDbContext.UserRoles.Where(c => c.RoleId == roleid).AsNoTracking().FirstOrDefault();
            return UserRole;
        }

        public List<IdentityUserRole<Guid>> GetRoleUser(Guid userid)
        {
            var Role = shopDbContext.UserRoles.Where(c => c.UserId == userid).AsNoTracking().ToList();
            return Role;
        }

        public void RemoveUserRole(IdentityUserRole<Guid> identityUserRole)
        {
            shopDbContext.UserRoles.Remove(identityUserRole);
            shopDbContext.SaveChanges();
        }
    }
}
