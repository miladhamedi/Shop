using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class ShopingCartDto
    {
        public int ShoppingCartId { get; set; }
        public string ProductCode { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal AmountSent { get; set; }
        public decimal Tax { get; set; }
        public int InvoiceNumber { get; set; }
        public string Warranty { get; set; }
        public int ProductId { get; set; }
        public Guid UserId { get; set; }
       
    }
}
