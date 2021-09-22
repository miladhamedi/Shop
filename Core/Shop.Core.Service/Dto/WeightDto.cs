using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class WeightDto
    {
        public int WeightId { get; set; }
     
        public int Weight_Max { get; set; }
      
        public int Weight_Min { get; set; }
      
        public decimal Weight_Price { get; set; }
    }
}
