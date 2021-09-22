using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class SettingRepository : ISettingRepository
    {
        private readonly ShopDbContext shopDbContext;

        public SettingRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public Setting GetSetting()
        {
            var setting = shopDbContext.Settings.FirstOrDefault();
            return setting;
        }
    }
}
