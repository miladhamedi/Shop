using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class InvoiceDto
    {
        public int InvoiceId { get; set; }
       
        public DateTime Date { get; set; }
        
        public bool Status { get; set; }
       
        public int Count { get; set; }
       
        public int InvoiceNumber { get; set; }
        
        public decimal Price { get; set; }
        
        public decimal  AmountSent { get; set; }
       
        public decimal Tax { get; set; }
      
        public string TransactionId { get; set; }
        
        public string RefrenceId { get; set; }
        public string InvoiceStatus { get; set; }
        public Guid UserId { get; set; }
    }
}
