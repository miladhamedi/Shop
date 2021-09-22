using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class TechnicalDetailRepository: ITechnicalDetailRepository
    {
        private readonly ShopDbContext shopDbContext;

        public TechnicalDetailRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public int AddTechnicalDetail(TechnicalDetail technicalDetail)
        {
            shopDbContext.TechnicalDetails.Add(technicalDetail);
            shopDbContext.SaveChanges();
            return technicalDetail.ProductId;
        }

        public TechnicalDetail GetByProductId(int productid)
        {
            var technical = shopDbContext.TechnicalDetails.Where(c => c.ProductId == productid).AsNoTracking().FirstOrDefault();
            return technical;
        }

        public void UpdateTechnicalDetail(TechnicalDetail technicalDetail)
        {
            shopDbContext.TechnicalDetails.Attach(technicalDetail);
            shopDbContext.Entry(technicalDetail).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }
    }
}
