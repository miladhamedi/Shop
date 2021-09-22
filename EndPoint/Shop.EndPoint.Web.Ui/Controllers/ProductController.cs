using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Common;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Categories;
using Shop.Core.Service.Services.Colors;
using Shop.Core.Service.Services.Comments;
using Shop.Core.Service.Services.Products;
using Shop.Core.Service.Services.ShopingCart;
using Shop.Core.Service.Services.TechnicalDetails;
using Shop.Core.Service.Services.User;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;
        private readonly ICategoryService categoryService;
        private readonly ICommentService commentService;
        private readonly IUserService userService;
        private readonly ITechnicalDetailService technicalDetailService;
        private readonly IShopingCartService shopingCartService;

        public ProductController(IProductService productService,
            IMapper mapper, ICategoryService categoryService,
            ICommentService commentService, IUserService userService,
            ITechnicalDetailService technicalDetailService,
            IShopingCartService shopingCartService
            )
        {
            this.productService = productService;
            this.mapper = mapper;
            this.categoryService = categoryService;
            this.commentService = commentService;
            this.userService = userService;
            this.technicalDetailService = technicalDetailService;
            this.shopingCartService = shopingCartService;
        }




        public IActionResult ProductByCategory(int catgoryid, int page = 1)
        {
            ShopActionResult<List<ProductByCateViewModel>> prolistor = new ShopActionResult<List<ProductByCateViewModel>>();

            var listProCat = productService.ProductByCatelist(catgoryid, page);

            prolistor.Page = listProCat.Page;
            prolistor.Pages = listProCat.Pages;

            List<ProductByCateViewModel> ProductByCateViewModels = new List<ProductByCateViewModel>();

            foreach (var item in listProCat.Data)
            {
                var ProCatList = mapper.Map<ProductByCateViewModel>(item);
                ProductByCateViewModels.Add(ProCatList);
            }
            prolistor.Data = ProductByCateViewModels;
            ViewBag.AllCategory = categoryService.GetAll();
            return View(prolistor);
        }

        public IActionResult ProductDetails(int productid)
        {
            var product = productService.ProductDetails(productid);
            var ProDetails = mapper.Map<ProductDetailsViewModel>(product);
            ViewBag.Message = TempData["Message"];
            ViewBag.Status = TempData["Status"];
            return View(ProDetails);

        }


        public IActionResult CommentProduct(string text, string username, int productid, string returnurl)
        {
            if (text != null)
            {
                var user = userService.GetByUserName(username);
                var product = productService.GetByIdPro(productid);
                CommentDto commentDto = new CommentDto();
                commentDto.Confirm = false;
                commentDto.Date = DateTime.Now;
                commentDto.NameFamily = user.NameFamily;
                commentDto.ProductName = product.Titel;
                commentDto.ProductId = product.ProductId;
                commentDto.IP = Convert.ToString(Request.HttpContext.Connection.RemotePort);
                commentDto.Text = text;
                commentDto.Email = user.Email;
                commentDto.UserId = user.Id;
                commentService.AddComment(commentDto);

                TempData["Message"] = "ارسال پیام موفق بعد از تایید ب نمایش در خواهد آمد";
                TempData["Status"] = "Ok";
                return LocalRedirect(returnurl);
            }



            TempData["Message"] = "ارسال پیام نا موفق بود";
            TempData["Status"] = "NotOk";
            return LocalRedirect(returnurl);

        }



        public IActionResult SearchProduct(string title, int page = 1)
        {
            ShopActionResult<List<ProductByCateViewModel>> prolistor = new ShopActionResult<List<ProductByCateViewModel>>();

            var listProduct = productService.SearchProduct(title, page);

            prolistor.Page = listProduct.Page;
            prolistor.Pages = listProduct.Pages;

            List<ProductByCateViewModel> ProductByCateViewModels = new List<ProductByCateViewModel>();

            foreach (var item in listProduct.Data)
            {
                var ProductList = mapper.Map<ProductByCateViewModel>(item);
                ProductByCateViewModels.Add(ProductList);
            }

            prolistor.Data = ProductByCateViewModels;
            ViewBag.TitleProduct = title;

            return View(prolistor);

        }



        public IActionResult SearchPrice(int categoryid, decimal min_price, decimal max_price, int page = 1)
        {
            ShopActionResult<List<ProductByCateViewModel>> prolistor = new ShopActionResult<List<ProductByCateViewModel>>();

            var listProduct = productService.SearchPrice(categoryid, min_price, max_price, page);

            prolistor.Page = page;
            prolistor.Pages = listProduct.Pages;

            List<ProductByCateViewModel> ProductByCateViewModels = new List<ProductByCateViewModel>();

            foreach (var item in listProduct.Data)
            {
                var ProductList = mapper.Map<ProductByCateViewModel>(item);
                ProductByCateViewModels.Add(ProductList);
            }

            prolistor.Data = ProductByCateViewModels;

            ViewBag.Pricemin = min_price;
            ViewBag.Pricemax = max_price;

            return View(prolistor);
        }

    }
}
