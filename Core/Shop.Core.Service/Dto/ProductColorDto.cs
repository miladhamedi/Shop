using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class ProductColorDto
    {
        public int ProductColorId { get; set; }
        public int ProductId { get; set; }
        public int ColorId { get; set; }
    }
}
