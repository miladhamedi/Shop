using Microsoft.EntityFrameworkCore;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopDbContext shopDbContext;

        public ProductRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public int AddProduct(Product product)
        {
           shopDbContext.Products.Add(product);
            shopDbContext.SaveChanges();
            return product.ProductId;
        }

        public List<Product> GetAllProduct()
        {
            var Listproduct = shopDbContext.Products.OrderByDescending(c=>c.Date).AsNoTracking().ToList();
            return Listproduct;
        }

        public List<Product> GetByCategoryId(int categoryid)
        {

            var ProCateList = shopDbContext.Products.Where(c => c.CategoryId == categoryid && c.ActiveInActive == true)
                .Include(c => c.Galleries).OrderByDescending(c => c.Date).ToList();

            return ProCateList;
        }

        public Product GetByProductId(int productid)
        {
            var product = shopDbContext.Products.Where(c => c.ProductId == productid).Include(c=>c.Galleries).AsNoTracking().FirstOrDefault();
            return product;
        }

        public Product GetProductById(int productid)
        {
            var product = shopDbContext.Products.Where(c => c.ProductId == productid && c.ActiveInActive == true && c.Stcok >= 1).Include(c => c.Galleries).FirstOrDefault();
            return product;
        }

        public List<Product> LastProduct()
        {
            var Lastproduct = shopDbContext.Products.OrderByDescending(c => c.Date).Include(c => c.Galleries).Take(4).ToList();
            return Lastproduct;
        }

        public List<Product> searchPrice(int categoryid , decimal min_price, decimal max_price)
        {
            var listProduct = shopDbContext.Products.Where(c => c.ActiveInActive == true && c.CategoryId == categoryid && c.Stcok >= 1).Include(c => c.Galleries).AsQueryable();
            var prolist = listProduct.Where(c => c.Price >= min_price && c.Price <= max_price).AsNoTracking().ToList();

            return prolist;
        }

        public List<Product> SearchProduct(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                var listProduct = shopDbContext.Products.Where(c => c.Titel.Contains(title)).Include(c => c.Galleries).AsNoTracking().ToList();
                return listProduct;
            }
            return null;
        }

        public void UpdateProduct(Product product)
        {
            shopDbContext.Products.Attach(product);
            shopDbContext.Entry(product).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }
    }
}
