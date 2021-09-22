using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Colors;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class ColorController : BaseController
    {
        private readonly IColorService colorService;
        private readonly IMapper mapper;

        public ColorController(IColorService colorService,
            IMapper mapper)
        {
            this.colorService = colorService;
            this.mapper = mapper;
        }

        public IActionResult Index(int page = 1)
        {
            ShopActionResult<List<ColorViewModel>> actionResult = new ShopActionResult<List<ColorViewModel>>();
            var listColor = colorService.GetAllColor(page);
            actionResult.Pages = listColor.Pages;
            actionResult.Page = page;
            List<ColorViewModel> colorViewModels = new List<ColorViewModel>();
            foreach (var item in listColor.Data)
            {
                var color = mapper.Map<ColorViewModel>(item);
                colorViewModels.Add(color);
            }
            actionResult.Data = colorViewModels;


            return View(actionResult);
        }



        public IActionResult Create()
        {
          
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ColorViewModel model)
        {
            if (ModelState.IsValid)
            {
                var Color = mapper.Map<ColorDto>(model);

                colorService.AddColor(Color);

                return RedirectToAction("Index");
            }
            return View(model);
        }


        public IActionResult Edit(int id)
        {
            var color = colorService.GetByColorId(id);
            if (color == null)
            {
                return RedirectToAction("Home","Error");
            }
            var Color = mapper.Map<ColorViewModel>(color);


            return View(Color);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ColorViewModel model)
        {

            if (ModelState.IsValid)
            {
               
                var color = colorService.GetByColorId(model.ColorId);

                color.ColorPro = model.ColorPro;
                color.ColorCode = model.ColorCode;
                color.ColorId = model.ColorId;
                colorService.UpdateColor(color);

                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
