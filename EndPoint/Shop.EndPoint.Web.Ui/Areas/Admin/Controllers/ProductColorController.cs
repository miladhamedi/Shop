using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Colors;
using Shop.Core.Service.Services.ProductColors;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class ProductColorController : BaseController
    {
        private readonly IColorService colorService;
        private readonly IMapper mapper;
        private readonly IProductColorService productColorService;

        public ProductColorController(IColorService colorService,
            IMapper mapper, IProductColorService productColorService)
        {
            this.colorService = colorService;
            this.mapper = mapper;
            this.productColorService = productColorService;
        }
        public IActionResult Index(int productid)
        {
            var ListColorProduct = colorService.GetByProductId(productid);
            List<ColorProductViewModel> colorViewModels = new List<ColorProductViewModel>();
            foreach (var item in ListColorProduct)
            {
                var color = mapper.Map<ColorProductViewModel>(item);
                colorViewModels.Add(color);
            }

            return View(colorViewModels);
        }

        public IActionResult Create(int productid, string returnUrl)
        {
            ViewBag.ProductId = productid;
            ViewBag.ReturnUrl = returnUrl;
            ViewBag.ListColor = new SelectList(colorService.GetAllColor(), "ColorId", "ColorPro");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductColorViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var color = mapper.Map<ProductColorDto>(model);
                productColorService.AddProductColor(color);
                if (returnUrl != null)
                {
                    return RedirectToAction("Index", "ProductColor", new { productid = model.ProductId });
                }
                else
                {
                    return RedirectToAction("Index", "Product");
                }

            }
            return View(model);
        }



        public IActionResult Delete(int colorid, int productid)
        {
            var ListColorProduct = colorService.GetByProductId(productid);
            var productColor = productColorService.GetColorByProductId(colorid, productid);
            if (ListColorProduct.Count == 1)
            {
                return RedirectToAction("Index", new { productid = productid });
            }
            productColorService.RemoveProductCololr(productColor);
            return RedirectToAction("Index", new { productid = productid });


        }


        public IActionResult Edit(int colorid, int productid)
        {
            var productColor = productColorService.GetColorByProductId(colorid, productid);
            ProductColorViewModel productColorViewModel = new ProductColorViewModel();
            productColorViewModel.ProductColorId = productColor.ProductColorId;
            productColorViewModel.ProductId = productColor.ProductId;
            ViewBag.ListColor = new SelectList(colorService.GetAllColor(), "ColorId", "ColorPro");
            return View(productColorViewModel);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Edit(ProductColorViewModel model)
        {
            var productcolor = productColorService.GetByProColorId(model.ProductColorId);
            productcolor.ColorId = model.ColorId;
            productcolor.ProductColorId = model.ProductColorId;
            productcolor.ProductId = model.ProductId;
            productColorService.UpdateProColor(productcolor);
            return RedirectToAction("Index", new { productid = model.ProductId });
        }


    }
}
