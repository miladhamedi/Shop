using AutoMapper;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Galleries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.ShopingCart
{
    public class ShopingCartService : IShopingCartService
    {
        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IMapper mapper;
        private readonly IUserRepositroy userRepositroy;
        private readonly IProductRepository productRepository;
        private readonly IGalleryService galleryService;

        public ShopingCartService(IShoppingCartRepository
            shoppingCartRepository,IMapper mapper,IUserRepositroy userRepositroy,
            IProductRepository productRepository,IGalleryService galleryService )
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.mapper = mapper;
            this.userRepositroy = userRepositroy;
            this.productRepository = productRepository;
            this.galleryService = galleryService;
        }

        public void AddCart(ShopingCartDto shoppingCart)
        {
            var Shoping = mapper.Map<ShoppingCart>(shoppingCart);
            shoppingCartRepository.AddCart(Shoping);
        }

        public List<ShopingCartDto> GetAllUserById(Guid userid)
        {
            List<ShopingCartDto> shopingCartDtos = new List<ShopingCartDto>();
            var listshoping = shoppingCartRepository.GetAllUserById(userid);
            foreach (var item in listshoping)
            {
                var shop = mapper.Map<ShopingCartDto>(item);
                shopingCartDtos.Add(shop);
            }
            return shopingCartDtos;
        }

        public List<ShopingCartDto> GetByInvoiceId(int invoiceid)
        {
            List<ShopingCartDto> shopingCartDtos = new List<ShopingCartDto>();
            var listShoping = shoppingCartRepository.GetByInvoiceId(invoiceid);
            foreach (var item in listShoping)
            {
                var shoping = mapper.Map<ShopingCartDto>(item);
                shopingCartDtos.Add(shoping);

            }
            return shopingCartDtos;
        }

        public ShopingCartDto GetCart(Guid userid, int productid)
        {
            var shoping = shoppingCartRepository.GetCart(userid, productid);
            var shop = mapper.Map<ShopingCartDto>(shoping);
            return shop;
        }

        public decimal GetDisCount(string username)
        {
            var User = userRepositroy.GetByUserName(username);
            var Shopping = shoppingCartRepository.GetAllUserById(User.Id);
            List<decimal> ListDiscount = new List<decimal>();
            foreach (var item in Shopping)
            {
                var product = productRepository.GetProductById(item.ProductId);
                var percent = product.DiscuntPercent == 0 ? 0 : product.DiscuntPercent;
                var percentDiscount =percent / 100;
                var price = item.Price;
                var pricepercent = price * percentDiscount;
                var pricepercentcount = pricepercent * item.Count;
                ListDiscount.Add(pricepercentcount);

            }
            return ListDiscount.Sum();
        }

        public List<ListCart> GetListCarts(Guid userid, int productnumber)
        {
            List<ListCart> listCarts = new List<ListCart>();
            var cartList = shoppingCartRepository.GetCartByNumber(userid, productnumber);
            foreach (var item in cartList)
            {
                var product = productRepository.GetProductById(item.ProductId);
                var PicName = galleryService.GetPicName(product.ProductId);

                ListCart listCart = new ListCart();

                listCart.ProductImge = PicName;
                listCart.ProductName = product.Titel;
                listCart.Count = item.Count;
                listCart.Price = item.Price;
                listCart.ProductCode = product.CodeProduct;
                listCart.ProductId = product.ProductId;

                listCarts.Add(listCart);


            }

            return listCarts;

        }

        public ShopingCartDto GetShopingCart(int cartid, Guid userid)
        {
            var cart = shoppingCartRepository.GetShopping(cartid, userid);
            var shoping = mapper.Map<ShopingCartDto>(cart);
            return shoping;
        }

        public void RemoveShopping(ShopingCartDto shoppingCart)
        {
            var Shoping = mapper.Map<ShoppingCart>(shoppingCart);
            shoppingCartRepository.RemoveShopping(Shoping);
        }

        public void UpdateCart(ShopingCartDto shoppingCart)
        {
            var Shoping = mapper.Map<ShoppingCart>(shoppingCart);
            shoppingCartRepository.UpdateCart(Shoping);
        }
    }
}
