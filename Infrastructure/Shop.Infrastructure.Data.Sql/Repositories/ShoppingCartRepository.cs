using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ShopDbContext shopDbContext;

        public ShoppingCartRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public void AddCart(ShoppingCart shoppingCart)
        {
            shopDbContext.ShoppingCarts.Add(shoppingCart);
            shopDbContext.SaveChanges();
        }


        public ShoppingCart GetCart(Guid userid, int productid)
        {
            var Cart = shopDbContext.ShoppingCarts.Where(c => c.UserId == userid && c.ProductId == productid && c.Status == false).AsNoTracking().FirstOrDefault();
            return Cart;
        }

       
      
        public List<ShoppingCart> GetAllUserById(Guid userid)
        {
            var cart = shopDbContext.ShoppingCarts.Where(c => c.UserId == userid && c.Status == false).AsNoTracking().ToList();
            return cart;
        }

        public void RemoveShopping(ShoppingCart shoppingCart)
        {
            shopDbContext.ShoppingCarts.Remove(shoppingCart);
            shopDbContext.SaveChanges();
        }

        public void UpdateCart(ShoppingCart shoppingCart)
        {
            shopDbContext.ShoppingCarts.Update(shoppingCart);
            shopDbContext.Entry(shoppingCart).State = EntityState.Modified;
            shopDbContext.SaveChanges();

        }

        public ShoppingCart GetShopping(int cartid, Guid userid)
        {
            var shopping = shopDbContext.ShoppingCarts.Where(c => c.ShoppingCartId == cartid && c.UserId == userid && c.Status == false).AsNoTracking().FirstOrDefault();
            return shopping;
        }

        public List<ShoppingCart> GetCartByNumber(Guid userid, int invoicenumber)
        {
            var invoice = shopDbContext.ShoppingCarts.Where(c => c.UserId == userid && c.InvoiceNumber == invoicenumber).AsNoTracking().ToList();
            return invoice;
        }

        public List<ShoppingCart> GetByInvoiceId(int invoiceid)
        {
            var listShopping = shopDbContext.ShoppingCarts.Where(c => c.InvoiceNumber == invoiceid && c.Status == true).AsNoTracking().ToList();
            return listShopping;
        }
    }
}
