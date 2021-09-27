using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Products;
using Shop.Core.Service.Services.TechnicalDetails;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class TechnicalDetailController : BaseController
    {
        private readonly ITechnicalDetailService technicalDetailService;
        private readonly IProductService productService;
        private readonly IMapper mapper;

        public TechnicalDetailController(ITechnicalDetailService technicalDetailService,
            IProductService productService, IMapper mapper)
        {
            this.technicalDetailService = technicalDetailService;
            this.productService = productService;
            this.mapper = mapper;
        }



        public IActionResult Create(int productid)
        {
            ViewBag.ProductName = productService.GetById(productid).Titel;
            ViewBag.ProductId = productid;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TechnicalDetailViewModel technicalDetailViewModel)
        {
            if (ModelState.IsValid)
            {
                var technicalDetail = mapper.Map<TechnicalDetailDto>(technicalDetailViewModel);
                var Productid = technicalDetailService.AddTechnicalDetail(technicalDetail);
                return RedirectToAction("Create", "Gallery", new { productid = Productid });

            }
            return View(technicalDetailViewModel);
        }




        public IActionResult Edit(int productid)
        {
            var technicaldetail = technicalDetailService.GetByProductId(productid);
            if (technicaldetail == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            var technicalDetail = mapper.Map<TechnicalDetailViewModel>(technicaldetail);
            return View(technicalDetail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TechnicalDetailViewModel technicalDetailView)
        {
            var technicaldetail = technicalDetailService.GetByProductId(technicalDetailView.ProductId);
            if (technicaldetail == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            technicaldetail.Warranty = technicalDetailView.Warranty;
            technicaldetail.Type = technicalDetailView.Type;
            technicaldetail.Model = technicalDetailView.Model;
            technicaldetail.ProductionYear = technicalDetailView.ProductionYear;
            technicaldetail.Manufacturer = technicalDetailView.Manufacturer;
            technicaldetail.ManufacturingCountry = technicalDetailView.ManufacturingCountry;
           
            technicalDetailService.UpdateTechnicalDetail(technicaldetail);
            return RedirectToAction("Edit", new { productid = technicalDetailView.ProductId });
        }
    }
}
