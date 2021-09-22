using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class WeightRepository : IWeightRepository
    {
        private readonly ShopDbContext shopDbContext;

        public WeightRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }
        public void AddWeight(Weight weight)
        {
            shopDbContext.Weights.Add(weight);
            shopDbContext.SaveChanges();
        }

        public List<Weight> GetAll()
        {
            var Weightlist = shopDbContext.Weights.AsNoTracking().ToList();
            return Weightlist;
        }

        public Weight GetById(int weightid)
        {
            var Weight = shopDbContext.Weights.Where(c => c.WeightId == weightid).AsNoTracking().SingleOrDefault();
            return Weight;
        }

        public decimal GetWeight_Price(int Weight_Min, int Weight_Max)
        {
            var WeightPrice = shopDbContext.Weights.Where(c => c.Weight_Min <= Weight_Min && c.Weight_Max >= Weight_Max).SingleOrDefault().Weight_Price;
            return  WeightPrice;
        }

        public void RemoveWeight(Weight weight)
        {
            shopDbContext.Weights.Remove(weight);
            shopDbContext.SaveChanges();
        }

        public void UpdateWeight(Weight weight)
        {
            shopDbContext.Weights.Attach(weight);
            shopDbContext.Entry(weight).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }

    }
}
