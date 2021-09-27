using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Core.Contract.Repositories;
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
        private readonly IProductColorRepository productColorRepository;

        public ProductColorController(IColorService colorService,
            IMapper mapper, IProductColorService productColorService,IProductColorRepository productColorRepository)
        {
            this.colorService = colorService;
            this.mapper = mapper;
            this.productColorService = productColorService;
            this.productColorRepository = productColorRepository;
        }
        public IActionResult Index(int productid)
        {
            var ListColorProduct = colorService.GetByProductId(productid);
            if (ListColorProduct.Count == 0)
            {
                return RedirectToAction("Notfound", "Manage");
            }
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


       
        public IActionResult Delete(int productcolorid ,int productid)
        {
            var ListColorProduct = colorService.GetByProductId(productid);
            var productColor = productColorRepository.GetByProColorId(productcolorid);
            if (productColor == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            if (ListColorProduct.Count == 1)
            {
                return RedirectToAction("Index", new { productid = productid });
            }
            productColorRepository.RemoveProductCololr(productColor);
            return RedirectToAction("Index", new { productid = productid });


        }


        public IActionResult Edit(int productcolorid)
        {
            var productColor = productColorRepository.GetByProColorId(productcolorid);
            if (productColor == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
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
            if (model == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            var productcolor = productColorRepository.GetByProColorId(model.ProductColorId);
            productcolor.ColorId = model.ColorId;
            productcolor.ProductColorId = model.ProductColorId;
            productcolor.ProductId = model.ProductId;
            productColorRepository.UpdateProColor(productcolor);
            return RedirectToAction("Index", new { productid = model.ProductId });
        }


    }
}
