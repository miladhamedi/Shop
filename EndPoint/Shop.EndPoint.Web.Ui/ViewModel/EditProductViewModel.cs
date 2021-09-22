using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class EditProductViewModel
    {
        public int ProductId { get; set; }
        public bool ActiveInActive { get; set; }
        public string Titel { get; set; }
        public decimal Price { get; set; }
        public decimal DiscuntPercent { get; set; }
        public int Stcok { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public decimal DiscuntedPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
