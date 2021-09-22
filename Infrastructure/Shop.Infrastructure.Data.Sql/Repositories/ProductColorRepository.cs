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
    public class ProductColorRepository : IProductColorRepository
    {
        private readonly ShopDbContext shopDbContext;

        public ProductColorRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public void AddProductColor(ProductColor productColor)
        {
            shopDbContext.ProductColors.Add(productColor);
            shopDbContext.SaveChanges();
        }

        public List<ProductColor> AllColorProId(int productid)
        {
            var ListColor = shopDbContext.ProductColors.Where(c => c.ProductId == productid).ToList();
            return ListColor;
        }

        public ProductColor GetByColorId(int colorid)
        {
            var color = shopDbContext.ProductColors.Where(c => c.ColorId == colorid).AsNoTracking().FirstOrDefault();
            return color;
        }

        public ProductColor GetByProColorId(int productcolorid)
        {
            var proColor = shopDbContext.ProductColors.Where(c => c.ProductColorId == productcolorid).AsNoTracking().FirstOrDefault();
            return proColor;
        }

        public ProductColor GetColorByProductId(int colorid, int productid)
        {
            var productColor = shopDbContext.ProductColors.Where(c => c.ColorId == colorid && c.ProductId == productid).AsNoTracking().FirstOrDefault();
            return productColor;
        }

        public void RemoveProductCololr(ProductColor productColor)
        {
            shopDbContext.ProductColors.Remove(productColor);
            shopDbContext.SaveChanges();
        }

        public void UpdateProColor(ProductColor productColor)
        {
            shopDbContext.ProductColors.Attach(productColor);
            shopDbContext.Entry(productColor).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }
    }
}
