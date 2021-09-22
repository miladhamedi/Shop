using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class TechnicalDetailDto
    {
        public int TechnicalDetailId { get; set; }
       
        public string Type { get; set; }
      
        public string Manufacturer { get; set; }
       
        public string ManufacturingCountry { get; set; }
      
        public string Model { get; set; }
      
        public string ProductionYear { get; set; }
      
        public string Warranty { get; set; }

        public int ProductId { get; set; }
    }
}
