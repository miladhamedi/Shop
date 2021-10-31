using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class UserRepositroy : IUserRepositroy
    {
        private readonly ShopDbContext shopDbContext;

        public UserRepositroy(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }


        public string GetEmailUser(Guid userid)
        {
            var userEmail = shopDbContext.Users.Where(c => c.Id == userid).FirstOrDefault().Email;
            return userEmail;

        }

        public void AddInformationUser(ApplicationUser applicationUser)
        {
            shopDbContext.Add(applicationUser);
            shopDbContext.SaveChanges();
        }

        public bool checkValueUser(string username)
        {
            var user = shopDbContext.Users.Where(a => a.UserName.Equals(username)).FirstOrDefault();

            if (user.City != null && user.Address != "" &&
                user.Province != null && user.City != "" &&
                user.PostalCode != null &&
                user.Address != null && user.Province != "" &&
                 user.PostalCode != "" &&
                user.IrCode != "" && user.IrCode != null)
                return true;
            else
                return false;
        }

        public ApplicationUser GetByUserName(string username)
        {
            var user = shopDbContext.Users.Where(c => c.UserName == username && c.EmailConfirmed == true ).AsNoTracking().FirstOrDefault();
            return user;
        }

        public void UpdatedUser(ApplicationUser applicationUser)
        {
            shopDbContext.Users.Attach(applicationUser);
            shopDbContext.Entry(applicationUser).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }

        public ApplicationUser GetByUserId(Guid userid)
        {
            var User = shopDbContext.Users.Where(c => c.Id == userid).AsNoTracking().FirstOrDefault();
            return User;
        }

        public string CheckRoleUser(string username)
        {
          
            var user = GetByUserName(username);
            var roleid = shopDbContext.UserRoles.Where(c => c.UserId == user.Id).FirstOrDefault().RoleId;
            var role = shopDbContext.Roles.Where(c => c.Id == roleid).FirstOrDefault().Name;
               
            return role;
        }

        public List<ApplicationUser> GetAllUser()
        {
            var Listuser = shopDbContext.Users.AsNoTracking().ToList();
            return Listuser;
        }

        public List<ApplicationUser> GetLastUser()
        {
            var Lastuser = shopDbContext.Users.OrderByDescending(c => c.Date).Take(5).ToList();
            return Lastuser;
        }

        public bool CheckConfirmPhone(string username)
        {
            var user = shopDbContext.Users.Where(c => c.UserName == username && c.PhoneNumberConfirmed == true).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;
        }
    }
}
