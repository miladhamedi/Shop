using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Contract.Repositories
{
    public interface IProductColorRepository
    {
        List<ProductColor> AllColorProId(int productid);
        void AddProductColor(ProductColor productColor);
        void RemoveProductCololr(ProductColor productColor);
        ProductColor GetByColorId(int colorid);
        void UpdateProColor(ProductColor productColor);
        ProductColor GetByProColorId(int productcolorid);
        ProductColor GetColorByProductId(int colorid, int productid);

    }
}
