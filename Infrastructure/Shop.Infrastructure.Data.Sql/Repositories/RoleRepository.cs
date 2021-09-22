using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ShopDbContext shopDbContext;

        public RoleRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public List<IdentityRole<Guid>> GetAllRole()
        {
            var ListRole = shopDbContext.Roles.ToList();
            return ListRole;
        }

        public IdentityRole<Guid> GetByRoleAdmin(string rolename = "Admin")
        {
            var Rolename = shopDbContext.Roles.Where(c => c.Name == rolename).FirstOrDefault();
            return Rolename;

        }

        public Guid GetByRoleId(string rolename)
        {
            var RoleName = shopDbContext.Roles.Where(c => c.Name == rolename).FirstOrDefault().Id;
            return RoleName;
        }

        public IdentityRole<Guid> GetByUserRoleId(string rolename = "User")
        {
            var Roleid = shopDbContext.Roles.Where(c => c.Name == rolename).FirstOrDefault();

            return Roleid;
        }

       

        public void AddRole(IdentityRole<Guid> identityRole)
        {
            shopDbContext.Roles.Add(identityRole);
            shopDbContext.SaveChanges(); 
        }

        public IdentityRole<Guid> GetById(Guid roleid)
        {
            var Role = shopDbContext.Roles.Where(c => c.Id == roleid).AsNoTracking().FirstOrDefault();
            return Role;
        }

        public void RemoveRole(IdentityRole<Guid> identityRole)
        {
            shopDbContext.Roles.Remove(identityRole);
            shopDbContext.SaveChanges();
        }

        public Guid GetByRoleName(string rolename)
        {
            var RoleId = shopDbContext.Roles.Where(c => c.Name == rolename).FirstOrDefault().Id;
            return RoleId;
        }
    }
}
