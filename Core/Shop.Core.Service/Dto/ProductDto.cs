using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class ProductDto
    {
    
        public int ProductId { get; set; }
      
        public string CodeProduct { get; set; }

        public string Titel { get; set; }
        
        public int Visit { get; set; }

        public decimal Price { get; set; }
    
        public decimal DiscuntPercent { get; set; }
       
        public decimal DiscuntedPrice { get; set; }
      
        public bool ActiveInActive { get; set; }
      
        public DateTime Date { get; set; }
    
        public int Stcok { get; set; }

        public string Description { get; set; }
        public int Weight { get; set; }
        public int CategoryId { get; set; }
        public Guid IdUser { get; set; }
        public List<Gallery> Galleries { get; set; }
    }
}
