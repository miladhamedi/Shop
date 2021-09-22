using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto.IndexDto
{
    public class MostdiscountsDto
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public string Warranty { get; set; }
        public string Picture { get; set; }
    }
}
