using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Common;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Categories;
using Shop.Core.Service.Services.Products;
using Shop.Core.Service.Services.User;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IUserService userService;

        public ProductController(IProductService productService, 
            ICategoryService categoryService,IUserService userService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.userService = userService;
        }
        public IActionResult Index(int page = 1)
        {
            ShopActionResult<List<ProductViewModel>> prolistor = new ShopActionResult<List<ProductViewModel>>();

            var prolist = productService.GetAllProduct(page);
            if (prolist.Data.Count == 0)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            prolistor.Page = prolist.Page;
            prolistor.Pages = prolist.Pages;
            List<ProductViewModel> productViewModels = new List<ProductViewModel>();
            foreach (var item in prolist.Data)
            {
                ProductViewModel product = new ProductViewModel();
                product.ActiveInActive = item.ActiveInActive;
                product.Date = item.Date;
                product.ProductId = item.ProductId;
                product.DiscuntPercent = item.DiscuntPercent;
                product.DiscuntedPrice = item.DiscuntedPrice;
                product.Price = item.Price;
                product.Stcok = item.Stcok;
                product.Titel = item.Titel;
                product.CodeProduct = item.CodeProduct.ToString();
                productViewModels.Add(product);
            }
            prolistor.Data = productViewModels;
            return View(prolistor);
        }


        public IActionResult Create()
        {
            ViewBag.ListCategory = new  SelectList(categoryService.GetAllCategory(),"CategoryId", "Titel");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                Random rnd = new Random();
                var codproduct = rnd.Next(100, 9999) + DateTime.Now.Second + 1;
                var priceDis = productService.PriceDiscount(model.Price, model.DiscuntPercent);
                var roundPriceDis = Math.Round(priceDis);
                var Appuser = User.Identity.Name;
                var user = userService.GetByUserName(Appuser);

                ProductDto product = new ProductDto();
                var roundPrice = Math.Round(model.Price);

                product.ActiveInActive = true;
                product.Date = DateTime.Now;
                product.Description = model.Description;
                product.DiscuntedPrice = roundPriceDis;
                product.DiscuntPercent = model.DiscuntPercent;
                product.Price = roundPrice;
                product.Stcok = model.Stcok;
                product.Titel = model.Titel;
                product.IdUser = user.Id;
                product.Visit = 0;
                product.Weight = model.Weight;
                product.CategoryId = model.CategoryId;
                product.CodeProduct = codproduct.ToString();

              var productId =  productService.AddProduct(product);
                return RedirectToAction("Create", "TechnicalDetail", new { productid = productId });
            }

            ViewBag.ListCategory = new SelectList(categoryService.GetAllCategory(), "CategoryId", "Titel", model.CategoryId);
            return View(model);
        }



        public IActionResult Edit(int id)
        {
            var product = productService.GetById(id);
            if (product == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            ViewBag.ListCategory = new SelectList(categoryService.GetAllCategory(), "CategoryId", "Titel", product.CategoryId);
            EditProductViewModel productViewModel = new EditProductViewModel();


            productViewModel.ActiveInActive = product.ActiveInActive;
            productViewModel.DiscuntedPrice = product.DiscuntedPrice;
            productViewModel.Description = product.Description;
            productViewModel.DiscuntPercent = product.DiscuntPercent;
            productViewModel.Price = product.Price;
            productViewModel.Stcok = product.Stcok;
            productViewModel.Titel = product.Titel;
            productViewModel.Weight = product.Weight;
            productViewModel.ProductId = product.ProductId;
            productViewModel.CategoryId = product.CategoryId;

            return View(productViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var discountPrice = productService.PriceDiscount(model.Price, model.DiscuntPercent);
                var product = productService.GetById(model.ProductId);

                product.ActiveInActive = model.ActiveInActive;
                product.DiscuntedPrice = discountPrice;
                product.Description = model.Description;
                product.DiscuntPercent = model.DiscuntPercent;
                product.Price = model.Price;
                product.Stcok = model.Stcok;
                product.Titel = model.Titel;
                product.Weight = model.Weight;
                product.ProductId = model.ProductId;
                product.CategoryId = model.CategoryId;

                productService.UpdateProduct(product);

                return RedirectToAction("Index");
            }

            ViewBag.ListCategory = new SelectList(categoryService.GetAllCategory(), "CategoryId", "Titel", model.CategoryId);
            return View(model);
           
        }


      
    }
}
