using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.ShopingCart
{
    public interface IShopingCartService
    {
        ShopingCartDto GetCart(Guid userid, int productid);
        void AddCart(ShopingCartDto shoppingCart);
        void UpdateCart(ShopingCartDto shoppingCart);
        List<ShopingCartDto> GetAllUserById(Guid userid);
        void RemoveShopping(ShopingCartDto shoppingCart);
        ShopingCartDto GetShopingCart(int cartid,Guid userid);
        decimal GetDisCount(string username);
        List<ListCart> GetListCarts(Guid userid,int productnumber);
        List<ShopingCartDto> GetByInvoiceId(int invoiceid);

    }
}
