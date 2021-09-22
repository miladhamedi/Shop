using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class UserPageRepository : IUserPageRepository
    {
        private readonly ShopDbContext shopDbContext;

        public UserPageRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }
       

        public void AddUserPage(UserPage userPage)
        {
            shopDbContext.UserPages.Add(userPage);
            shopDbContext.SaveChanges();
        }

        public List<UserPage> GetAll()
        {
            var userpages = shopDbContext.UserPages.AsNoTracking().ToList();
            return userpages;
        }

        public UserPage GetById(int userpageid)
        {
            var userpage = shopDbContext.UserPages.Where(c => c.UserPageId == userpageid).AsNoTracking().FirstOrDefault();
            return userpage;
        }

        public UserPage GetUserByRole(Guid role, string actionname, string controllername)
        {
            var userpage = shopDbContext.UserPages.Where
                (c => c.RoleId == role && c.PageNameEn == actionname && c.ControllerName == controllername).FirstOrDefault();
            return userpage;
        }

        public void RemoveUserPage(UserPage userPage)
        {
           shopDbContext.UserPages.Remove(userPage);
            shopDbContext.SaveChanges();


        }

        public void UpdateUserPage(UserPage userPage)
        {
            shopDbContext.UserPages.Attach(userPage);
            shopDbContext.Entry(userPage).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }
    }
}
