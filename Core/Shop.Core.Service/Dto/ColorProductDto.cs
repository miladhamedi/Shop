using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class ColorProductDto
    {
        public int ColorId { get; set; }
        public string ColorPro { get; set; }
        public string ColorCode { get; set; }
        public int ProductId { get; set; }
        public int ProductColorId { get; set; }
    }
}
