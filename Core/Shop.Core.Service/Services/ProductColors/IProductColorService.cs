using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.ProductColors
{
    public interface IProductColorService
    {
        void AddProductColor(ProductColorDto productColorDto);
        void RemoveProductCololr(ProductColorDto productColorDto);
        ProductColorDto GetByColorId(int colorid);
        List<ProductColorDto> AllColorProId(int productid);
        ProductColorDto GetByProColorId(int productcolorid);
        void UpdateProColor(ProductColorDto productColorDto);
        ProductColorDto GetColorByProductId(int colorid, int productid);
    }
}
