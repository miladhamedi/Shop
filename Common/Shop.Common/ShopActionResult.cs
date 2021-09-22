using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Common
{
    public class ShopActionResult<T>
    {
        public T Data { get; set; }
        public int Page { get; set; } = 1;
        public int Pages { get; set; }
        public int ItemCount { get; set; }
        public int Counts { get; set; }

    }
}
