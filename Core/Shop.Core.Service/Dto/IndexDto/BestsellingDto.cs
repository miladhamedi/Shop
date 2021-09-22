using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto.IndexDto
{
    public class BestsellingDto
    {
        public int ProductId { get; set; }
        public string Picture { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public string Title { get; set; }
        public decimal DisCountPercent { get; set; }

    }
}
