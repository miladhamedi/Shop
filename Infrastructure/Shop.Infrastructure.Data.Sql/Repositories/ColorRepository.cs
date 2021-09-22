using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class ColorRepository : IColorRepository
    {
        private readonly ShopDbContext shopDbContext;

        public ColorRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public void AddColor(Color color)
        {
            shopDbContext.Colors.Add(color);
            shopDbContext.SaveChanges();
        }

        public List<Color> GetAll()
        {
            var Cololist = shopDbContext.Colors.ToList();
            return Cololist;
        }

        public Color GetByColorId(int colorid)
        {
            var Colo = shopDbContext.Colors.Where(c => c.ColorId == colorid).AsNoTracking().FirstOrDefault();
            return Colo;
        }

        

        public void UpdateColor(Color color)
        {
            shopDbContext.Colors.Attach(color);
            shopDbContext.Entry(color).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }
    }
}
