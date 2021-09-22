using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Common;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Weights;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class WeightController : BaseController
    {
        private readonly IWeightService weightService;
        private readonly IMapper mapper;

        public WeightController(IWeightService weightService, IMapper mapper)
        {
            this.weightService = weightService;
            this.mapper = mapper;
        }
        public IActionResult Index(int page = 1)
        {
            ShopActionResult<List<WeightViewModel>> actionResult = new ShopActionResult<List<WeightViewModel>>();
            var ListWeight = weightService.GetAllWeight(page);
            actionResult.Pages = ListWeight.Pages;
            actionResult.Page = ListWeight.Page;
            List<WeightViewModel> weightViewModels = new List<WeightViewModel>();
            foreach (var item in ListWeight.Data)
            {
                var weight = mapper.Map<WeightViewModel>(item);
                weightViewModels.Add(weight);
            }
            actionResult.Data = weightViewModels;
            return View(actionResult);
        }




        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(WeightViewModel model)
        {
            if(ModelState.IsValid)
            {
                var Weight = mapper.Map<WeightDto>(model);
                weightService.AddWeight(Weight);
                return RedirectToAction("Index");
            }
            return View(model);
         
        }



        public IActionResult Edit(int id)
        {
            var weight = weightService.GetById(id);
            var Weight = mapper.Map<WeightViewModel>(weight);
            return View(Weight);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(WeightViewModel model)
        {
            var weight = weightService.GetById(model.WeightId);
            weight.Weight_Max = model.Weight_Max;
            weight.Weight_Min = model.Weight_Min;
            weight.Weight_Price = model.Weight_Price;
            weightService.UpdateWeight(weight);
            return RedirectToAction("Index");
        }


        public IActionResult Remove(int id)
        {
            var weight = weightService.GetById(id);
            weightService.RemoveWeight(weight);
            return RedirectToAction("Index");
        }
    }
}
