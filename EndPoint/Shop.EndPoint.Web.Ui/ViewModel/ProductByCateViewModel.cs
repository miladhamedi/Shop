using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public  class ProductByCateViewModel
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal DisCountPrice { get; set; }
        public string Picture { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public decimal DisCountPercent { get; set; }

    }
}
