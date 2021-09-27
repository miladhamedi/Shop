using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Categories;
using Shop.EndPoint.Web.Ui.Areas.Admin.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public CategoryController(
            ICategoryService  categoryService,IMapper mapper)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
        }
        public IActionResult Index(int page = 1)
        {
            ShopActionResult<List<CategoryViewModel>> actionResult = new ShopActionResult<List<CategoryViewModel>>();
            var Listcategory = categoryService.GetAll(page);
            if (Listcategory.Data.Count == 0)
                return RedirectToAction("Notfound", "Manage");
            actionResult.Pages = Listcategory.Pages;
            actionResult.Page = page;
            List<CategoryViewModel> categoryViewModels = new List<CategoryViewModel>();
            foreach (var item in Listcategory.Data)
            {
                var category = mapper.Map<CategoryViewModel>(item);
                categoryViewModels.Add(category);
            }
            actionResult.Data = categoryViewModels;


            return View(actionResult);
        }



        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category = mapper.Map<CategoryDto>(model);

                categoryService.AddCategory(category);

                return RedirectToAction("Index");
            }
            return View(model);
        }


        public IActionResult Edit(int id)
        {
            var category = categoryService.GetById(id);
            if (category == null)
                return RedirectToAction("Notfound", "Manage");

            var Category = mapper.Map<CategoryViewModel>(category);

            return View(Category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryViewModel model)
        {

            if (ModelState.IsValid)
            {
             
                var Category = categoryService.GetById(model.CategoryId);
                if (Category == null)
                    return RedirectToAction("Notfound", "Manage");
                Category.ActivePassive = model.ActivePassive;
                Category.Titel = model.Titel;
                Category.CategoryId = model.CategoryId;


                categoryService.UpdateCategory(Category);

                return RedirectToAction("Index");

            }
            return View(model);
        }
    }
}
