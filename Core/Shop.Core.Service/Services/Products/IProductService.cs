using Shop.Common;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Products
{
    public interface IProductService
    {
        ShopActionResult<List<ProductByCateDto>> ProductByCatelist(int categoryid, int page = 1);
        ProductDetailsDto ProductDetails(int productid);
        ProductDto GetByIdPro(int productid);
        ShopActionResult<List<ProductByCateDto>> SearchProduct(string title,int page = 1);
        ShopActionResult<List<ProductByCateDto>> SearchPrice(int categoryid, decimal min_price, decimal max_price, int page = 1);
        ShopActionResult<List<ProductDto>> GetAllProduct(int page = 1);
        void UpdateProduct(ProductDto product);
        int AddProduct(ProductDto product);
        decimal PriceDiscount(decimal price , decimal discount);
        ProductDto GetById(int productid);

    }
}
