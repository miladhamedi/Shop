using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface IShoppingCartRepository
    {
        ShoppingCart GetCart(Guid userid, int productid);
        void AddCart(ShoppingCart shoppingCart);
        void UpdateCart(ShoppingCart shoppingCart);
        List<ShoppingCart> GetAllUserById(Guid userid);
        void RemoveShopping(ShoppingCart shoppingCart);
        ShoppingCart GetShopping(int cartid,Guid userid);
        List<ShoppingCart> GetCartByNumber(Guid userid, int invoicenumber);
        List<ShoppingCart> GetByInvoiceId(int invoiceid);

    }
}
