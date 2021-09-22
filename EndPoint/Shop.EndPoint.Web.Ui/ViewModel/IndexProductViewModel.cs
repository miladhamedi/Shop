using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class IndexProductViewModel
    {
        public int ProductId { get; set; }
        public string Titel { get; set; }
        public decimal Price { get; set; }
        public decimal DiscuntPercent { get; set; }
        public decimal DiscuntedPrice { get; set; }
        public int Stcok { get; set; }
        public int Weight { get; set; }
        public int CategoryId { get; set; }
        public bool ActiveInActive { get; set; }
        public DateTime Date { get; set; }
        public string CodeProduct { get; set; }

    }
}
