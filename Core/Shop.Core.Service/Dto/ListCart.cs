using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class ListCart
    {
        public int Count { get; set; }
        public decimal Price { get; set; }
        public string ProductCode { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImge { get; set; }


    }
}
