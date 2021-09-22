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
    public class ProductIndexRepository : IProductIndexRepository
    {
        private readonly ShopDbContext shopDbContext;

        public ProductIndexRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }
       
        public List<ShoppingCart> Bestselling()
        {
            var bessellPro = shopDbContext.ShoppingCarts.Include(c => c.Product)
                .ThenInclude(c => c.Galleries)
                .Where(c => c.Status == true).OrderByDescending(c => c.Count).AsNoTracking().ToList();
            return bessellPro;
        }

        public List<Product> InexpensiveProduct()
        {
            var listpro = shopDbContext.Products.OrderByDescending(c => c.Date).AsQueryable();
            var proList = listpro.Include(c => c.Galleries).Where(c=>c.ActiveInActive == true && c.Stcok >= 1).OrderBy(c => c.Price).AsNoTracking().ToList();
            return proList;
        }

        public List<Product> Mostdiscounts()
        {
            var prodiscountli = shopDbContext.Products.Where(c=>c.Stcok >= 1 && c.ActiveInActive == true).Include(c => c.Galleries).Include(c => c.TechnicalDetails).Include(c=>c.ProductColors).OrderByDescending(c => c.DiscuntPercent).AsNoTracking().ToList();
            
            return prodiscountli;
        }

        public List<Product> NewProduct()
        {
            var listProNew = shopDbContext.Products.Where(c => c.ActiveInActive == true && c.Stcok >= 1)
                .OrderByDescending(c => c.Date).Include(c => c.Galleries).AsNoTracking().Take(5).ToList();
            return listProNew;
        }
    }
}
